namespace Wisej.CodeProject.win
{
    partial class BSOutManager
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
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.deviceBindingSource = new Wisej.Web.BindingSource(this.components);
            this.deviceTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.DeviceTableAdapter();
            this.dataGridView3 = new Wisej.Web.DataGridView();
            this.colDeviceid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colIp = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Name = new Wisej.Web.DataGridViewComboBoxColumn();
            this.colDsp_Chno = new Wisej.Web.DataGridViewComboBoxColumn();
            this.Column0 = new Wisej.Web.DataGridViewButtonColumn();
            this.colPath_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.채널 = new Wisej.Web.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "Device";
            this.deviceBindingSource.DataSource = this.dataSet1;
            this.deviceBindingSource.Filter = "device=0";
            // 
            // deviceTableAdapter
            // 
            this.deviceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowSortingDataSource = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colDeviceid,
            this.colDevicename,
            this.채널,
            this.colIp,
            this.colDsp_Name,
            this.colDsp_Chno,
            this.Column0,
            this.colPath_1});
            this.dataGridView3.DataSource = this.deviceBindingSource;
            this.dataGridView3.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(836, 444);
            this.dataGridView3.TabIndex = 2;
            // 
            // colDeviceid
            // 
            this.colDeviceid.DataPropertyName = "DeviceId";
            this.colDeviceid.HeaderText = "No";
            this.colDeviceid.Name = "colDeviceid";
            this.colDeviceid.ReadOnly = true;
            this.colDeviceid.Width = 40;
            // 
            // colDevicename
            // 
            this.colDevicename.DataPropertyName = "DeviceName";
            this.colDevicename.HeaderText = "DeviceName";
            this.colDevicename.Name = "colDevicename";
            this.colDevicename.ReadOnly = true;
            this.colDevicename.Width = 150;
            // 
            // colIp
            // 
            this.colIp.DataPropertyName = "ip";
            this.colIp.HeaderText = "IP Address";
            this.colIp.Name = "colIp";
            this.colIp.ReadOnly = true;
            this.colIp.Width = 110;
            // 
            // colDsp_Name
            // 
            this.colDsp_Name.DataPropertyName = "dsp_name";
            this.colDsp_Name.HeaderText = "DSP";
            this.colDsp_Name.Name = "colDsp_Name";
            this.colDsp_Name.Width = 120;
            // 
            // colDsp_Chno
            // 
            this.colDsp_Chno.DataPropertyName = "dsp_chno";
            this.colDsp_Chno.HeaderText = "DSP CH";
            this.colDsp_Chno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.colDsp_Chno.Name = "colDsp_Chno";
            this.colDsp_Chno.Width = 60;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "적용";
            this.Column0.Name = "Column0";
            this.Column0.Text = "적용";
            // 
            // colPath_1
            // 
            this.colPath_1.DataPropertyName = "path";
            this.colPath_1.HeaderText = "위치";
            this.colPath_1.Name = "colPath_1";
            this.colPath_1.ReadOnly = true;
            this.colPath_1.Width = 180;
            // 
            // panel1
            // 
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 70);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 444);
            this.panel2.TabIndex = 4;
            this.panel2.TabStop = true;
            // 
            // 채널
            // 
            this.채널.DataPropertyName = "chspk";
            this.채널.HeaderText = "채널";
            this.채널.Name = "채널";
            this.채널.Width = 60;
            // 
            // BSOutManager
            // 
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BSOutManager";
            this.Size = new System.Drawing.Size(836, 514);
            this.Load += new System.EventHandler(this.BSOutManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private Web.BindingSource deviceBindingSource;
        private DataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter;
        private Web.DataGridView dataGridView3;
        private Web.DataGridViewTextBoxColumn colDeviceid;
        private Web.DataGridViewTextBoxColumn colDevicename;
        private Web.DataGridViewTextBoxColumn colIp;
        private Web.DataGridViewTextBoxColumn colPath_1;
        private Web.DataGridViewComboBoxColumn colDsp_Chno;
        private Web.DataGridViewComboBoxColumn colDsp_Name;
        private Web.Panel panel1;
        private Web.Panel panel2;
        private Web.DataGridViewButtonColumn Column0;
        private Web.DataGridViewTextBoxColumn 채널;
    }
}
