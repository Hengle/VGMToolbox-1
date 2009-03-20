﻿namespace VGMToolbox.forms
{
    partial class Extract_OffsetFinderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.lblDragNDrop = new System.Windows.Forms.Label();
            this.tbSourcePaths = new System.Windows.Forms.TextBox();
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.cbSearchAsHex = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchString = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDoCut = new System.Windows.Forms.CheckBox();
            this.lblOutputExtension = new System.Windows.Forms.Label();
            this.tbOutputExtension = new System.Windows.Forms.TextBox();
            this.gbCutSizeOptions = new System.Windows.Forms.GroupBox();
            this.cbOffsetSize = new System.Windows.Forms.ComboBox();
            this.lblByteOrder = new System.Windows.Forms.Label();
            this.lblStoredIn = new System.Windows.Forms.Label();
            this.cbByteOrder = new System.Windows.Forms.ComboBox();
            this.lblInBytes = new System.Windows.Forms.Label();
            this.lblInBytes2 = new System.Windows.Forms.Label();
            this.lblFromStart = new System.Windows.Forms.Label();
            this.lblHasSize = new System.Windows.Forms.Label();
            this.tbStaticCutsize = new System.Windows.Forms.TextBox();
            this.tbCutSizeOffset = new System.Windows.Forms.TextBox();
            this.rbOffsetBasedCutSize = new System.Windows.Forms.RadioButton();
            this.rbStaticCutSize = new System.Windows.Forms.RadioButton();
            this.lblStringAtOffset = new System.Windows.Forms.Label();
            this.tbSearchStringOffset = new System.Windows.Forms.TextBox();
            this.pnlLabels.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.grpFiles.SuspendLayout();
            this.grpCriteria.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbCutSizeOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabels
            // 
            this.pnlLabels.Location = new System.Drawing.Point(0, 422);
            this.pnlLabels.Size = new System.Drawing.Size(874, 19);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Size = new System.Drawing.Size(874, 20);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(0, 345);
            this.tbOutput.Size = new System.Drawing.Size(874, 77);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(0, 325);
            this.pnlButtons.Size = new System.Drawing.Size(874, 20);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(814, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDoTask
            // 
            this.btnDoTask.Location = new System.Drawing.Point(754, 0);
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.lblDragNDrop);
            this.grpFiles.Controls.Add(this.tbSourcePaths);
            this.grpFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFiles.Location = new System.Drawing.Point(0, 23);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(874, 61);
            this.grpFiles.TabIndex = 5;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Files to Search";
            // 
            // lblDragNDrop
            // 
            this.lblDragNDrop.AutoSize = true;
            this.lblDragNDrop.Location = new System.Drawing.Point(3, 42);
            this.lblDragNDrop.Name = "lblDragNDrop";
            this.lblDragNDrop.Size = new System.Drawing.Size(172, 13);
            this.lblDragNDrop.TabIndex = 1;
            this.lblDragNDrop.Text = "Drag and Drop files to search here.";
            // 
            // tbSourcePaths
            // 
            this.tbSourcePaths.AllowDrop = true;
            this.tbSourcePaths.Location = new System.Drawing.Point(6, 19);
            this.tbSourcePaths.Name = "tbSourcePaths";
            this.tbSourcePaths.Size = new System.Drawing.Size(282, 20);
            this.tbSourcePaths.TabIndex = 0;
            this.tbSourcePaths.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbSourcePaths_DragDrop);
            this.tbSourcePaths.DragEnter += new System.Windows.Forms.DragEventHandler(this.doDragEnter);
            // 
            // grpCriteria
            // 
            this.grpCriteria.Controls.Add(this.cbSearchAsHex);
            this.grpCriteria.Controls.Add(this.label2);
            this.grpCriteria.Controls.Add(this.tbSearchString);
            this.grpCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCriteria.Location = new System.Drawing.Point(0, 84);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Size = new System.Drawing.Size(874, 45);
            this.grpCriteria.TabIndex = 6;
            this.grpCriteria.TabStop = false;
            this.grpCriteria.Text = "Criteria";
            // 
            // cbSearchAsHex
            // 
            this.cbSearchAsHex.AutoSize = true;
            this.cbSearchAsHex.Location = new System.Drawing.Point(294, 18);
            this.cbSearchAsHex.Name = "cbSearchAsHex";
            this.cbSearchAsHex.Size = new System.Drawing.Size(87, 17);
            this.cbSearchAsHex.TabIndex = 2;
            this.cbSearchAsHex.Text = "Treat as Hex";
            this.cbSearchAsHex.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search String";
            // 
            // tbSearchString
            // 
            this.tbSearchString.Location = new System.Drawing.Point(83, 16);
            this.tbSearchString.Name = "tbSearchString";
            this.tbSearchString.Size = new System.Drawing.Size(205, 20);
            this.tbSearchString.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDoCut);
            this.groupBox3.Controls.Add(this.lblOutputExtension);
            this.groupBox3.Controls.Add(this.tbOutputExtension);
            this.groupBox3.Controls.Add(this.gbCutSizeOptions);
            this.groupBox3.Controls.Add(this.lblStringAtOffset);
            this.groupBox3.Controls.Add(this.tbSearchStringOffset);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(874, 182);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cut Options (all values are relative to the location of the file to be cut)";
            // 
            // cbDoCut
            // 
            this.cbDoCut.AutoSize = true;
            this.cbDoCut.Location = new System.Drawing.Point(9, 19);
            this.cbDoCut.Name = "cbDoCut";
            this.cbDoCut.Size = new System.Drawing.Size(83, 17);
            this.cbDoCut.TabIndex = 15;
            this.cbDoCut.Text = "Extract Files";
            this.cbDoCut.UseVisualStyleBackColor = true;
            this.cbDoCut.CheckedChanged += new System.EventHandler(this.cbDoCut_CheckedChanged);
            // 
            // lblOutputExtension
            // 
            this.lblOutputExtension.AutoSize = true;
            this.lblOutputExtension.Location = new System.Drawing.Point(234, 43);
            this.lblOutputExtension.Name = "lblOutputExtension";
            this.lblOutputExtension.Size = new System.Drawing.Size(107, 13);
            this.lblOutputExtension.TabIndex = 14;
            this.lblOutputExtension.Text = "Output File Extension";
            // 
            // tbOutputExtension
            // 
            this.tbOutputExtension.Location = new System.Drawing.Point(347, 40);
            this.tbOutputExtension.Name = "tbOutputExtension";
            this.tbOutputExtension.Size = new System.Drawing.Size(92, 20);
            this.tbOutputExtension.TabIndex = 13;
            // 
            // gbCutSizeOptions
            // 
            this.gbCutSizeOptions.Controls.Add(this.cbOffsetSize);
            this.gbCutSizeOptions.Controls.Add(this.lblByteOrder);
            this.gbCutSizeOptions.Controls.Add(this.lblStoredIn);
            this.gbCutSizeOptions.Controls.Add(this.cbByteOrder);
            this.gbCutSizeOptions.Controls.Add(this.lblInBytes);
            this.gbCutSizeOptions.Controls.Add(this.lblInBytes2);
            this.gbCutSizeOptions.Controls.Add(this.lblFromStart);
            this.gbCutSizeOptions.Controls.Add(this.lblHasSize);
            this.gbCutSizeOptions.Controls.Add(this.tbStaticCutsize);
            this.gbCutSizeOptions.Controls.Add(this.tbCutSizeOffset);
            this.gbCutSizeOptions.Controls.Add(this.rbOffsetBasedCutSize);
            this.gbCutSizeOptions.Controls.Add(this.rbStaticCutSize);
            this.gbCutSizeOptions.Location = new System.Drawing.Point(9, 66);
            this.gbCutSizeOptions.Name = "gbCutSizeOptions";
            this.gbCutSizeOptions.Size = new System.Drawing.Size(430, 111);
            this.gbCutSizeOptions.TabIndex = 2;
            this.gbCutSizeOptions.TabStop = false;
            this.gbCutSizeOptions.Text = "Cut Size Options";
            // 
            // cbOffsetSize
            // 
            this.cbOffsetSize.FormattingEnabled = true;
            this.cbOffsetSize.Location = new System.Drawing.Point(138, 63);
            this.cbOffsetSize.Name = "cbOffsetSize";
            this.cbOffsetSize.Size = new System.Drawing.Size(100, 21);
            this.cbOffsetSize.TabIndex = 12;
            this.cbOffsetSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbOffsetSize_KeyPress);
            this.cbOffsetSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbOffsetSize_KeyDown);
            // 
            // lblByteOrder
            // 
            this.lblByteOrder.AutoSize = true;
            this.lblByteOrder.Location = new System.Drawing.Point(244, 89);
            this.lblByteOrder.Name = "lblByteOrder";
            this.lblByteOrder.Size = new System.Drawing.Size(57, 13);
            this.lblByteOrder.TabIndex = 11;
            this.lblByteOrder.Text = "byte order.";
            // 
            // lblStoredIn
            // 
            this.lblStoredIn.AutoSize = true;
            this.lblStoredIn.Location = new System.Drawing.Point(64, 89);
            this.lblStoredIn.Name = "lblStoredIn";
            this.lblStoredIn.Size = new System.Drawing.Size(68, 13);
            this.lblStoredIn.TabIndex = 10;
            this.lblStoredIn.Text = "and stored in";
            // 
            // cbByteOrder
            // 
            this.cbByteOrder.FormattingEnabled = true;
            this.cbByteOrder.Location = new System.Drawing.Point(138, 86);
            this.cbByteOrder.Name = "cbByteOrder";
            this.cbByteOrder.Size = new System.Drawing.Size(100, 21);
            this.cbByteOrder.TabIndex = 9;
            // 
            // lblInBytes
            // 
            this.lblInBytes.AutoSize = true;
            this.lblInBytes.Location = new System.Drawing.Point(244, 21);
            this.lblInBytes.Name = "lblInBytes";
            this.lblInBytes.Size = new System.Drawing.Size(46, 13);
            this.lblInBytes.TabIndex = 8;
            this.lblInBytes.Text = "in bytes.";
            // 
            // lblInBytes2
            // 
            this.lblInBytes2.AutoSize = true;
            this.lblInBytes2.Location = new System.Drawing.Point(244, 66);
            this.lblInBytes2.Name = "lblInBytes2";
            this.lblInBytes2.Size = new System.Drawing.Size(46, 13);
            this.lblInBytes2.TabIndex = 7;
            this.lblInBytes2.Text = "in bytes.";
            // 
            // lblFromStart
            // 
            this.lblFromStart.AutoSize = true;
            this.lblFromStart.Location = new System.Drawing.Point(244, 44);
            this.lblFromStart.Name = "lblFromStart";
            this.lblFromStart.Size = new System.Drawing.Size(147, 13);
            this.lblFromStart.TabIndex = 6;
            this.lblFromStart.Text = "from the start of the file to cut.";
            // 
            // lblHasSize
            // 
            this.lblHasSize.AutoSize = true;
            this.lblHasSize.Location = new System.Drawing.Point(66, 66);
            this.lblHasSize.Name = "lblHasSize";
            this.lblHasSize.Size = new System.Drawing.Size(66, 13);
            this.lblHasSize.TabIndex = 5;
            this.lblHasSize.Text = "and has size";
            // 
            // tbStaticCutsize
            // 
            this.tbStaticCutsize.Location = new System.Drawing.Point(138, 18);
            this.tbStaticCutsize.Name = "tbStaticCutsize";
            this.tbStaticCutsize.Size = new System.Drawing.Size(100, 20);
            this.tbStaticCutsize.TabIndex = 3;
            // 
            // tbCutSizeOffset
            // 
            this.tbCutSizeOffset.Location = new System.Drawing.Point(138, 41);
            this.tbCutSizeOffset.Name = "tbCutSizeOffset";
            this.tbCutSizeOffset.Size = new System.Drawing.Size(100, 20);
            this.tbCutSizeOffset.TabIndex = 2;
            // 
            // rbOffsetBasedCutSize
            // 
            this.rbOffsetBasedCutSize.AutoSize = true;
            this.rbOffsetBasedCutSize.Location = new System.Drawing.Point(6, 42);
            this.rbOffsetBasedCutSize.Name = "rbOffsetBasedCutSize";
            this.rbOffsetBasedCutSize.Size = new System.Drawing.Size(117, 17);
            this.rbOffsetBasedCutSize.TabIndex = 1;
            this.rbOffsetBasedCutSize.TabStop = true;
            this.rbOffsetBasedCutSize.Text = "Cut Size is at Offset";
            this.rbOffsetBasedCutSize.UseVisualStyleBackColor = true;
            this.rbOffsetBasedCutSize.CheckedChanged += new System.EventHandler(this.rbStaticCutSize_CheckedChanged);
            // 
            // rbStaticCutSize
            // 
            this.rbStaticCutSize.AutoSize = true;
            this.rbStaticCutSize.Location = new System.Drawing.Point(6, 19);
            this.rbStaticCutSize.Name = "rbStaticCutSize";
            this.rbStaticCutSize.Size = new System.Drawing.Size(111, 17);
            this.rbStaticCutSize.TabIndex = 0;
            this.rbStaticCutSize.TabStop = true;
            this.rbStaticCutSize.Text = "Use Static Cutsize";
            this.rbStaticCutSize.UseVisualStyleBackColor = true;
            this.rbStaticCutSize.CheckedChanged += new System.EventHandler(this.rbStaticCutSize_CheckedChanged);
            // 
            // lblStringAtOffset
            // 
            this.lblStringAtOffset.AutoSize = true;
            this.lblStringAtOffset.Location = new System.Drawing.Point(6, 43);
            this.lblStringAtOffset.Name = "lblStringAtOffset";
            this.lblStringAtOffset.Size = new System.Drawing.Size(124, 13);
            this.lblStringAtOffset.TabIndex = 1;
            this.lblStringAtOffset.Text = "Search String is at Offset";
            // 
            // tbSearchStringOffset
            // 
            this.tbSearchStringOffset.Location = new System.Drawing.Point(136, 40);
            this.tbSearchStringOffset.Name = "tbSearchStringOffset";
            this.tbSearchStringOffset.Size = new System.Drawing.Size(92, 20);
            this.tbSearchStringOffset.TabIndex = 0;
            this.tbSearchStringOffset.Text = "0x00";
            // 
            // Extract_OffsetFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpCriteria);
            this.Controls.Add(this.grpFiles);
            this.Name = "Extract_OffsetFinderForm";
            this.Text = "Extract_OffsetFinderForm";
            this.Controls.SetChildIndex(this.pnlLabels, 0);
            this.Controls.SetChildIndex(this.tbOutput, 0);
            this.Controls.SetChildIndex(this.pnlTitle, 0);
            this.Controls.SetChildIndex(this.pnlButtons, 0);
            this.Controls.SetChildIndex(this.grpFiles, 0);
            this.Controls.SetChildIndex(this.grpCriteria, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.pnlLabels.ResumeLayout(false);
            this.pnlLabels.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.grpFiles.ResumeLayout(false);
            this.grpFiles.PerformLayout();
            this.grpCriteria.ResumeLayout(false);
            this.grpCriteria.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbCutSizeOptions.ResumeLayout(false);
            this.gbCutSizeOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.TextBox tbSourcePaths;
        private System.Windows.Forms.Label lblDragNDrop;
        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchString;
        private System.Windows.Forms.CheckBox cbSearchAsHex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSearchStringOffset;
        private System.Windows.Forms.Label lblStringAtOffset;
        private System.Windows.Forms.GroupBox gbCutSizeOptions;
        private System.Windows.Forms.RadioButton rbOffsetBasedCutSize;
        private System.Windows.Forms.RadioButton rbStaticCutSize;
        private System.Windows.Forms.TextBox tbStaticCutsize;
        private System.Windows.Forms.TextBox tbCutSizeOffset;
        private System.Windows.Forms.Label lblHasSize;
        private System.Windows.Forms.Label lblByteOrder;
        private System.Windows.Forms.Label lblStoredIn;
        private System.Windows.Forms.ComboBox cbByteOrder;
        private System.Windows.Forms.Label lblInBytes;
        private System.Windows.Forms.Label lblInBytes2;
        private System.Windows.Forms.Label lblFromStart;
        private System.Windows.Forms.Label lblOutputExtension;
        private System.Windows.Forms.TextBox tbOutputExtension;
        private System.Windows.Forms.ComboBox cbOffsetSize;
        private System.Windows.Forms.CheckBox cbDoCut;
    }
}