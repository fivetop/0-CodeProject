﻿namespace Wisej.CodeProject.win
{
    partial class BSLevelManager
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
            this.deviceBindingSource = new Wisej.Web.BindingSource(this.components);
            this.dataSet1 = new Wisej.CodeProject.DataSet1();
            this.deviceTableAdapter = new Wisej.CodeProject.DataSet1TableAdapters.DeviceTableAdapter();
            this.panel1 = new Wisej.Web.Panel();
            this.button3 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.panel2 = new Wisej.Web.Panel();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colDeviceid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDevicename = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colIp = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Name = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Chno = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colDsp_Vol = new Wisej.Web.DataGridViewNumericUpDownColumn();
            this.colDsp_Vol_Em = new Wisej.Web.DataGridViewNumericUpDownColumn();
            this.colPath_1 = new Wisej.Web.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "Device";
            this.deviceBindingSource.DataSource = this.dataSet1;
            this.deviceBindingSource.Filter = "device=0";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceTableAdapter
            // 
            this.deviceTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 70);
            this.panel1.TabIndex = 4;
            this.panel1.TabStop = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "시스템적용(전체볼륨)";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "비상전체-데이터변경";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "일반전체-데이터변경";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox2.LabelText = "비상 방송 볼륨선택";
            this.comboBox2.Location = new System.Drawing.Point(341, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 38);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.LabelText = "일반 방송 볼륨선택";
            this.comboBox1.Location = new System.Drawing.Point(8, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 38);
            this.comboBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 450);
            this.panel2.TabIndex = 5;
            this.panel2.TabStop = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colDeviceid,
            this.colDevicename,
            this.colIp,
            this.colDsp_Name,
            this.colDsp_Chno,
            this.colDsp_Vol,
            this.colDsp_Vol_Em,
            this.colPath_1});
            this.dataGridView1.DataSource = this.deviceBindingSource;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 450);
            this.dataGridView1.TabIndex = 3;
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
            this.colDsp_Name.ReadOnly = true;
            this.colDsp_Name.Width = 120;
            // 
            // colDsp_Chno
            // 
            this.colDsp_Chno.DataPropertyName = "dsp_chno";
            this.colDsp_Chno.HeaderText = "DSP CH";
            this.colDsp_Chno.Name = "colDsp_Chno";
            this.colDsp_Chno.ReadOnly = true;
            this.colDsp_Chno.Width = 60;
            // 
            // colDsp_Vol
            // 
            this.colDsp_Vol.DataPropertyName = "dsp_vol";
            this.colDsp_Vol.HeaderText = "볼륨";
            this.colDsp_Vol.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colDsp_Vol.Name = "colDsp_Vol";
            this.colDsp_Vol.Width = 80;
            // 
            // colDsp_Vol_Em
            // 
            this.colDsp_Vol_Em.DataPropertyName = "dsp_vol_em";
            this.colDsp_Vol_Em.HeaderText = "볼륨(비상)";
            this.colDsp_Vol_Em.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colDsp_Vol_Em.Name = "colDsp_Vol_Em";
            this.colDsp_Vol_Em.Width = 80;
            // 
            // colPath_1
            // 
            this.colPath_1.DataPropertyName = "path";
            this.colPath_1.HeaderText = "위치";
            this.colPath_1.Name = "colPath_1";
            this.colPath_1.ReadOnly = true;
            this.colPath_1.Width = 180;
            // 
            // BSLevelManager
            // 
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BSLevelManager";
            this.Size = new System.Drawing.Size(837, 520);
            this.Load += new System.EventHandler(this.BSLevelManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Web.BindingSource deviceBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.DeviceTableAdapter deviceTableAdapter;
        private Web.Panel panel1;
        private Web.Panel panel2;
        private Web.ComboBox comboBox1;
        private Web.Button button3;
        private Web.Button button2;
        private Web.Button button1;
        private Web.ComboBox comboBox2;
        private Web.DataGridView dataGridView1;
        private Web.DataGridViewTextBoxColumn colDeviceid;
        private Web.DataGridViewTextBoxColumn colDevicename;
        private Web.DataGridViewTextBoxColumn colIp;
        private Web.DataGridViewTextBoxColumn colDsp_Name;
        private Web.DataGridViewTextBoxColumn colDsp_Chno;
        private Web.DataGridViewNumericUpDownColumn colDsp_Vol;
        private Web.DataGridViewNumericUpDownColumn colDsp_Vol_Em;
        private Web.DataGridViewTextBoxColumn colPath_1;
    }
}
