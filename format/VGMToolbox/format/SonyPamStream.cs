﻿using System;
using System.Collections.Generic;
using System.IO;

using VGMToolbox.util;

namespace VGMToolbox.format
{
    public class SonyPamStream : Mpeg2Stream
    {
        new public const string DefaultAudioExtension = ".at3";

        public const string Atrac3AudioExtension = ".at3";
        public const string Ac3AudioExtension = ".ac3";
        public const string LpcmAudioExtension = ".lpcm";

        public static readonly byte[] Atrac3Bytes = new byte[] { 0x1E, 0x60, 0x14, 0x00 };
        public static readonly byte[] Ac3Bytes = new byte[] { 0x1E, 0x60, 0x14, 0x30 };
        public static readonly byte[] LpcmBytes = new byte[] { 0x1E, 0x61, 0x80, 0x40 };

        public const string M2vVideoExtension = ".m2v";
        public const string AvcVideoExtension = ".264";

        public static readonly byte[] M2vBytes = new byte[] { 0x00, 0x00, 0x01, 0xB3 };
        public static readonly byte[] AvcBytes = new byte[] { 0x00, 0x00, 0x00, 0x01 };

        public SonyPamStream(string path)
            : base(path)
        {
            this.UsesSameIdForMultipleAudioTracks = false;
            this.FileExtensionAudio = Atrac3AudioExtension;
            this.FileExtensionVideo = AvcVideoExtension;

            base.BlockIdDictionary[BitConverter.ToUInt32(Mpeg2Stream.PacketStartByes, 0)] = new BlockSizeStruct(PacketSizeType.Static, 0xE); // Pack Header
            base.BlockIdDictionary[BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xBD }, 0)] = new BlockSizeStruct(PacketSizeType.SizeBytes, 2); // Audio Stream, two bytes following equal length (Big Endian)
            // base.BlockIdDictionary[BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xBF }, 0)] = new BlockSizeStruct(PacketSizeType.SizeBytes, 2); // Audio Stream, two bytes following equal length (Big Endian)
        }

        protected override int GetAudioPacketHeaderSize(Stream readStream, long currentOffset)
        {
            int headerSize;
            UInt16 checkBytes;
            OffsetDescription od = new OffsetDescription();

            od.OffsetByteOrder = Constants.BigEndianByteOrder;
            od.OffsetSize = "2";
            od.OffsetValue = "6";

            checkBytes = (UInt16)ParseFile.GetVaryingByteValueAtRelativeOffset(readStream, od, currentOffset);

            switch (checkBytes)
            {
                // Thanks to FastElbJa and creator of pmfdemuxer (used to compare output) for this information
                case 0x8100:
                    headerSize = 0x07;
                    break;
                case 0x8180:
                case 0x8101:
                    headerSize = 0x0C;
                    break;
                case 0x8181:
                    headerSize = 0x0F;
                    break;
                default:
                    headerSize = 0;
                    // throw new FormatException(String.Format("Unexpected secondary bytes found for block starting at 0x{0}: 0x{1}", currentOffset.ToString("X8"), checkBytes.ToString("X4")));
                    break;
            }
            return headerSize;
        }

        protected override bool IsThisAnAudioBlock(byte[] blockToCheck)
        {
            return ((blockToCheck[3] >= 0xBD) &&
                    (blockToCheck[3] <= 0xDF) &&
                    (blockToCheck[3] != 0xBE) &&
                    (blockToCheck[3] != 0xBF));
        }
        protected override bool IsThisAVideoBlock(byte[] blockToCheck)
        {
            return ((blockToCheck[3] >= 0xE0) && (blockToCheck[3] <= 0xEF));
        }

        protected override string GetAudioFileExtension(Stream readStream, long currentOffset)
        {
            string fileExtension;
            byte[] checkBytes;

            checkBytes = ParseFile.ParseSimpleOffset(readStream, (currentOffset + 0xE), 4);

            if (ParseFile.CompareSegment(checkBytes, 0, Atrac3Bytes))
            {
                fileExtension = Atrac3AudioExtension;
            }
            else if (ParseFile.CompareSegment(checkBytes, 0, Ac3Bytes))
            {
                fileExtension = Ac3AudioExtension;
            }
            else if (ParseFile.CompareSegment(checkBytes, 0, LpcmBytes))
            {
                fileExtension = LpcmAudioExtension;
            }
            else
            {
                fileExtension = ".bin";
            }

            return fileExtension;
        }
        protected override string GetVideoFileExtension(Stream readStream, long currentOffset)
        {
            string fileExtension;
            byte[] checkBytes;
            int videoHeaderSize = this.GetVideoPacketHeaderSize(readStream, currentOffset);
            
            checkBytes = ParseFile.ParseSimpleOffset(readStream, (currentOffset + videoHeaderSize + 6), 4);

            if (ParseFile.CompareSegment(checkBytes, 0, AvcBytes))
            {
                fileExtension = AvcVideoExtension;
            }
            else if (ParseFile.CompareSegment(checkBytes, 0, M2vBytes))
            {
                fileExtension = M2vVideoExtension;
            }
            else
            {
                fileExtension = ".bin";
            }

            return fileExtension;
        }

        protected override void DoFinalTasks(Dictionary<uint, FileStream> outputFiles, bool addHeader)
        {
            byte[] headerBytes;
            byte[] aa3HeaderBytes;
            uint headerBlock;
            string sourceFile;

            foreach (uint streamId in outputFiles.Keys)
            {
                if (this.IsThisAnAudioBlock(BitConverter.GetBytes(streamId)))
                {
                    headerBytes = ParseFile.ParseSimpleOffset(outputFiles[streamId], 0, 0x8);

                    if (BitConverter.ToUInt32(headerBytes, 0) != 0)
                    {
                        // remove all header chunks
                        string cleanedFile = FileUtil.RemoveAllChunksFromFile(outputFiles[streamId], headerBytes);

                        // close stream and rename file
                        sourceFile = outputFiles[streamId].Name;

                        outputFiles[streamId].Close();
                        outputFiles[streamId].Dispose();

                        File.Delete(sourceFile);
                        File.Move(cleanedFile, sourceFile);

                        // add header
                        if (addHeader)
                        {
                            Array.Reverse(headerBytes);
                            headerBlock = BitConverter.ToUInt32(headerBytes, 4);

                            string headeredFile = Path.ChangeExtension(sourceFile, Atrac3Plus.FileExtension);
                            aa3HeaderBytes = Atrac3Plus.GetAa3Header(headerBlock);
                            FileUtil.AddHeaderToFile(aa3HeaderBytes, sourceFile, headeredFile);

                            File.Delete(sourceFile);
                        }
                    }
                }
            }
        }
    }
}