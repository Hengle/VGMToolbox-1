﻿using System.IO;
using System.Windows.Forms;

using VGMToolbox.dbutil;

namespace VGMToolbox.forms
{
    public partial class Auditing_CollectionBuilderForm : VgmtForm
    {
        private static readonly string DB_PATH =
            Path.Combine(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "db"), "collection.s3db");
        
        public Auditing_CollectionBuilderForm(TreeNode pTreeNode)
            : base(pTreeNode)
        {
            this.lblTitle.Text = "Collection Builder";
            
            InitializeComponent();

            loadSystemList();
        }

        private void loadSystemList()
        {
            this.comboBox1.DataSource = SqlLiteUtil.GetSimpleDataTable(DB_PATH, "SYSTEMS");
            this.comboBox1.DisplayMember = "SystemName";
            this.comboBox1.ValueMember = "SystemId";
        }
    }
}
