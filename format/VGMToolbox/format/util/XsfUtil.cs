﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

using VGMToolbox.format;
using VGMToolbox.util;

namespace VGMToolbox.format.util
{
    public class XsfUtil
    {
        public struct Xsf2ExeStruct
        {
            public bool IncludeExtension;
            public bool StripGsfHeader;        
        }

        public struct TimePsf2Struct
        {
            public bool IncludeExtension;
            public bool StripGsfHeader;
        }

        public static string ExtractCompressedDataSection(string pPath, Xsf2ExeStruct pXsf2ExeStruct)
        {
            string outputFile = null;
            
            using (FileStream fs = File.OpenRead(pPath))
            {
                Type dataType = FormatUtil.getObjectType(fs);

                Xsf vgmData = new Xsf();
                vgmData.Initialize(fs, pPath);

                if (vgmData.CompressedProgramLength > 0)
                {
                    BinaryWriter bw;
                    outputFile = Path.GetDirectoryName(pPath) + Path.DirectorySeparatorChar;
                    outputFile += (pXsf2ExeStruct.IncludeExtension ? Path.GetFileName(pPath) : Path.GetFileNameWithoutExtension(pPath)) + ".data.bin";


                    bw = new BinaryWriter(File.Create(outputFile));

                    InflaterInputStream inflater;
                    int read;
                    byte[] data = new byte[4096];

                    fs.Seek((long)(Xsf.RESERVED_SECTION_OFFSET + vgmData.ReservedSectionLength), SeekOrigin.Begin);
                    inflater = new InflaterInputStream(fs);

                    while ((read = inflater.Read(data, 0, data.Length)) > 0)
                    {
                        bw.Write(data, 0, read);
                    }

                    bw.Close();
                    inflater.Close();
                    inflater.Dispose();

                    // strip GSF header
                    if (pXsf2ExeStruct.StripGsfHeader)
                    {
                        string strippedOutputFileName = outputFile + ".strip";

                        using (FileStream gsfStream = File.OpenRead(outputFile))
                        {
                            long fileOffset = 0x0C;
                            int fileLength = (int)(gsfStream.Length - fileOffset) + 1;

                            ParseFile.ExtractChunkToFile(gsfStream, fileOffset, fileLength,
                                strippedOutputFileName);
                        }

                        File.Copy(strippedOutputFileName, outputFile, true);
                        File.Delete(strippedOutputFileName);
                    }

                } // if (vgmData.CompressedProgramLength > 0)
            } // using (FileStream fs = File.OpenRead(pPath))       

            return outputFile;
        }

        public static string ExtractReservedSection(string pPath, Xsf2ExeStruct pXsf2ExeStruct)
        {
            string outputFile = null;

            using (FileStream fs = File.OpenRead(pPath))
            {
                Type dataType = FormatUtil.getObjectType(fs);

                Xsf vgmData = new Xsf();
                vgmData.Initialize(fs, pPath);

                if (vgmData.ReservedSectionLength > 0)
                {
                    outputFile = String.Format("{0}.reserved.bin",
                        (pXsf2ExeStruct.IncludeExtension ? Path.GetFileName(pPath) : Path.GetFileNameWithoutExtension(pPath)));
                    outputFile = Path.Combine(Path.GetDirectoryName(pPath), outputFile);
                    
                    ParseFile.ExtractChunkToFile(fs, Xsf.RESERVED_SECTION_OFFSET, 
                        (int)vgmData.ReservedSectionLength, outputFile);

                } // if (vgmData.CompressedProgramLength > 0)
            } // using (FileStream fs = File.OpenRead(pPath))       

            return outputFile;        
        }

        public static Ps2SequenceData.Ps2SqTimingStruct GetTimeForPsf2File(string pSqPath, int pSequenceId)
        {
            Ps2SequenceData.Ps2SqTimingStruct time = new Ps2SequenceData.Ps2SqTimingStruct();
            int minutes;
            double seconds;

            try
            {
                using (FileStream fs = File.Open(pSqPath, FileMode.Open, FileAccess.Read))
                {                    
                    Ps2SequenceData ps2SequenceData = new Ps2SequenceData(fs);

                    time = ps2SequenceData.getTimeInSecondsForSequenceNumber(fs, pSequenceId);

                    /*
                    minutes = (int)(time.TimeInSeconds / 60d);
                    seconds = (time.TimeInSeconds - (minutes * 60));
                    seconds = Math.Ceiling(seconds);

                    if (seconds > 59)
                    {
                        minutes++;
                        seconds -= 60;
                    }
                    */
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

            return time;
        }
    }
}