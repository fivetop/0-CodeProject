namespace Wisej.CodeProject.win
{
    partial class BSInManager
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new Wisej.Web.Panel();
            this.dataGridView3 = new Wisej.Web.DataGridView();
            this.colDevicechnnelid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Column1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colChname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicein = new Wisej.Web.DataGridViewComboBoxColumn();
            this.colDeviceinch = new Wisej.Web.DataGridViewComboBoxColumn();
            this.Column0 = new Wisej.Web.DataGridViewButtonColumn();
            this.colDeviceid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.deviceChannelBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.panel2 = new Wisej.Web.Panel();
            this.deviceChannelTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.DeviceChannelTableAdapter();
            this.deviceTableAdapter1 = new Wisej.CodeProject.DataSet1TableAdapters.DeviceTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceChannelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 469);
            this.panel1.TabIndex = 5;
            this.panel1.TabStop = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowSortingDataSource = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colDevicechnnelid,
            this.Column1,
            this.colChname,
            this.colDevicein,
            this.colDeviceinch,
            this.Column0,
            this.colDeviceid});
            this.dataGridView3.DataSource = this.deviceChannelBindingSource;
            this.dataGridView3.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(838, 469);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.DataUpdated += new Wisej.Web.DataGridViewDataUpdatedEventHandler(this.dataGridView3_DataUpdated);
            // 
            // colDevicechnnelid
            // 
            this.colDevicechnnelid.DataPropertyName = "DeviceChnnelId";
            this.colDevicechnnelid.HeaderText = "No";
            this.colDevicechnnelid.Name = "colDevicechnnelid";
            this.colDevicechnnelid.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DSP";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // colChname
            // 
            this.colChname.DataPropertyName = "chname";
            this.colChname.HeaderText = "DSP CH";
            this.colChname.Name = "colChname";
            this.colChname.Width = 60;
            // 
            // colDevicein
            // 
            this.colDevicein.DataPropertyName = "devicein";
            this.colDevicein.HeaderText = "입력장치";
            this.colDevicein.Name = "colDevicein";
            this.colDevicein.Width = 150;
            // 
            // colDeviceinch
            // 
            this.colDeviceinch.DataPropertyName = "deviceinch";
            this.colDeviceinch.HeaderText = "채널";
            this.colDeviceinch.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.colDeviceinch.Name = "colDeviceinch";
            this.colDeviceinch.Width = 60;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "적용";
            this.Column0.Name = "Column0";
            this.Column0.Text = "적용";
            this.Column0.Width = 120;
            // 
            // colDeviceid
            // 
            this.colDeviceid.DataPropertyName = "DeviceId";
            this.colDeviceid.HeaderText = "DeviceId";
            this.colDeviceid.Name = "colDeviceid";
            this.colDeviceid.Visible = false;
            // 
            // deviceChannelBindingSource
            // 
            this.deviceChannelBindingSource.DataMember = "DeviceChannel";
            this.deviceChannelBindingSource.DataSource = this.dataSet1;
            this.deviceChannelBindingSource.Filter = "io=0";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 70);
            this.panel2.TabIndex = 6;
            this.panel2.TabStop = true;
            // 
            // deviceChannelTableAdapter
            // 
            this.deviceChannelTableAdapter.ClearBeforeFill = true;
            // 
            // deviceTableAdapter1
            // 
            this.deviceTableAdapter1.ClearBeforeFill = true;
            // 
            // BSInManager
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BSInManager";
            this.Size = new System.Drawing.Size(838, 539);
            this.Load += new System.EventHandler(this.BSInManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceChannelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Panel panel1;
        private Web.DataGridView dataGridView3;
        private Web.DataGridViewButtonColumn Column0;
        private Web.Panel panel2;
        private Web.DataGridViewTextBoxColumn colDevicechnnelid;
        private Web.DataGridViewTextBoxColumn Column1;
        private Web.DataGridViewTextBoxColumn colChname;
        private Web.BindingSource deviceChannelBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.DeviceChannelTableAdapter deviceChannelTableAdapter;
        private Web.DataGridViewTextBoxColumn colDeviceid;
        private DataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter1;
        private Web.DataGridViewComboBoxColumn colDevicein;
        private Web.DataGridViewComboBoxColumn colDeviceinch;
    }
}
