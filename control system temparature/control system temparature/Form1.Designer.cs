namespace control_system_temparature
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alarmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmTimeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLARMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scadaSystemDataSet = new control_system_temparature.ScadaSystemDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.acknowledgedAlaramIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCKNOWELEGEDALARAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scadaSystemDataSet2 = new control_system_temparature.ScadaSystemDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSignal = new System.Windows.Forms.TextBox();
            this.aLARMTableAdapter = new control_system_temparature.ScadaSystemDataSetTableAdapters.ALARMTableAdapter();
            this.aCKNOWELEGED_ALARAMTableAdapter = new control_system_temparature.ScadaSystemDataSet2TableAdapters.ACKNOWELEGED_ALARAMTableAdapter();
            this.tank1 = new NationalInstruments.UI.WindowsForms.Tank();
            this.tank2 = new NationalInstruments.UI.WindowsForms.Tank();
            this.tank3 = new NationalInstruments.UI.WindowsForms.Tank();
            this.tank4 = new NationalInstruments.UI.WindowsForms.Tank();
            this.tank5 = new NationalInstruments.UI.WindowsForms.Tank();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLARMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scadaSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCKNOWELEGEDALARAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scadaSystemDataSet2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tank1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank5)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tank5);
            this.groupBox2.Controls.Add(this.tank4);
            this.groupBox2.Controls.Add(this.tank3);
            this.groupBox2.Controls.Add(this.tank2);
            this.groupBox2.Controls.Add(this.tank1);
            this.groupBox2.Location = new System.Drawing.Point(684, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 293);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alarmIdDataGridViewTextBoxColumn,
            this.alarmStatusDataGridViewTextBoxColumn,
            this.alarmTimeStampDataGridViewTextBoxColumn,
            this.alarmTypeDataGridViewTextBoxColumn,
            this.sensorIdDataGridViewTextBoxColumn,
            this.measurementValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aLARMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 247);
            this.dataGridView1.TabIndex = 1;
            // 
            // alarmIdDataGridViewTextBoxColumn
            // 
            this.alarmIdDataGridViewTextBoxColumn.DataPropertyName = "AlarmId";
            this.alarmIdDataGridViewTextBoxColumn.HeaderText = "AlarmId";
            this.alarmIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alarmIdDataGridViewTextBoxColumn.Name = "alarmIdDataGridViewTextBoxColumn";
            this.alarmIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.alarmIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // alarmStatusDataGridViewTextBoxColumn
            // 
            this.alarmStatusDataGridViewTextBoxColumn.DataPropertyName = "AlarmStatus";
            this.alarmStatusDataGridViewTextBoxColumn.HeaderText = "AlarmStatus";
            this.alarmStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alarmStatusDataGridViewTextBoxColumn.Name = "alarmStatusDataGridViewTextBoxColumn";
            this.alarmStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // alarmTimeStampDataGridViewTextBoxColumn
            // 
            this.alarmTimeStampDataGridViewTextBoxColumn.DataPropertyName = "AlarmTimeStamp";
            this.alarmTimeStampDataGridViewTextBoxColumn.HeaderText = "AlarmTimeStamp";
            this.alarmTimeStampDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alarmTimeStampDataGridViewTextBoxColumn.Name = "alarmTimeStampDataGridViewTextBoxColumn";
            this.alarmTimeStampDataGridViewTextBoxColumn.Width = 125;
            // 
            // alarmTypeDataGridViewTextBoxColumn
            // 
            this.alarmTypeDataGridViewTextBoxColumn.DataPropertyName = "AlarmType";
            this.alarmTypeDataGridViewTextBoxColumn.HeaderText = "AlarmType";
            this.alarmTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alarmTypeDataGridViewTextBoxColumn.Name = "alarmTypeDataGridViewTextBoxColumn";
            this.alarmTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sensorIdDataGridViewTextBoxColumn
            // 
            this.sensorIdDataGridViewTextBoxColumn.DataPropertyName = "SensorId";
            this.sensorIdDataGridViewTextBoxColumn.HeaderText = "SensorId";
            this.sensorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sensorIdDataGridViewTextBoxColumn.Name = "sensorIdDataGridViewTextBoxColumn";
            this.sensorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // measurementValueDataGridViewTextBoxColumn
            // 
            this.measurementValueDataGridViewTextBoxColumn.DataPropertyName = "MeasurementValue";
            this.measurementValueDataGridViewTextBoxColumn.HeaderText = "MeasurementValue";
            this.measurementValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measurementValueDataGridViewTextBoxColumn.Name = "measurementValueDataGridViewTextBoxColumn";
            this.measurementValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // aLARMBindingSource
            // 
            this.aLARMBindingSource.DataMember = "ALARM";
            this.aLARMBindingSource.DataSource = this.scadaSystemDataSet;
            // 
            // scadaSystemDataSet
            // 
            this.scadaSystemDataSet.DataSetName = "ScadaSystemDataSet";
            this.scadaSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acknowledgedAlaramIdDataGridViewTextBoxColumn,
            this.alarmIdDataGridViewTextBoxColumn1,
            this.alarmTypeDataGridViewTextBoxColumn1,
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.aCKNOWELEGEDALARAMBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(2, 295);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(676, 257);
            this.dataGridView2.TabIndex = 2;
            // 
            // acknowledgedAlaramIdDataGridViewTextBoxColumn
            // 
            this.acknowledgedAlaramIdDataGridViewTextBoxColumn.DataPropertyName = "AcknowledgedAlaramId";
            this.acknowledgedAlaramIdDataGridViewTextBoxColumn.HeaderText = "AcknowledgedAlaramId";
            this.acknowledgedAlaramIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acknowledgedAlaramIdDataGridViewTextBoxColumn.Name = "acknowledgedAlaramIdDataGridViewTextBoxColumn";
            this.acknowledgedAlaramIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.acknowledgedAlaramIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // alarmIdDataGridViewTextBoxColumn1
            // 
            this.alarmIdDataGridViewTextBoxColumn1.DataPropertyName = "AlarmId";
            this.alarmIdDataGridViewTextBoxColumn1.HeaderText = "AlarmId";
            this.alarmIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.alarmIdDataGridViewTextBoxColumn1.Name = "alarmIdDataGridViewTextBoxColumn1";
            this.alarmIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // alarmTypeDataGridViewTextBoxColumn1
            // 
            this.alarmTypeDataGridViewTextBoxColumn1.DataPropertyName = "AlarmType";
            this.alarmTypeDataGridViewTextBoxColumn1.HeaderText = "AlarmType";
            this.alarmTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.alarmTypeDataGridViewTextBoxColumn1.Name = "alarmTypeDataGridViewTextBoxColumn1";
            this.alarmTypeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCKNOWELEGEDALARAMBindingSource
            // 
            this.aCKNOWELEGEDALARAMBindingSource.DataMember = "ACKNOWELEGED_ALARAM";
            this.aCKNOWELEGEDALARAMBindingSource.DataSource = this.scadaSystemDataSet2;
            // 
            // scadaSystemDataSet2
            // 
            this.scadaSystemDataSet2.DataSetName = "ScadaSystemDataSet2";
            this.scadaSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 272);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarms";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(2, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 278);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shelved Alarms";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(696, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(642, 239);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configuration Manager";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of Tanks";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Input temparature High Limit";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input Temparature low limit";
            // 
            // textBoxSignal
            // 
            this.textBoxSignal.Location = new System.Drawing.Point(81, 105);
            this.textBoxSignal.Name = "textBoxSignal";
            this.textBoxSignal.Size = new System.Drawing.Size(100, 22);
            this.textBoxSignal.TabIndex = 8;
            this.textBoxSignal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aLARMTableAdapter
            // 
            this.aLARMTableAdapter.ClearBeforeFill = true;
            // 
            // aCKNOWELEGED_ALARAMTableAdapter
            // 
            this.aCKNOWELEGED_ALARAMTableAdapter.ClearBeforeFill = true;
            // 
            // tank1
            // 
            this.tank1.Location = new System.Drawing.Point(12, 21);
            this.tank1.Name = "tank1";
            this.tank1.Size = new System.Drawing.Size(105, 178);
            this.tank1.TabIndex = 0;
            // 
            // tank2
            // 
            this.tank2.Location = new System.Drawing.Point(268, 21);
            this.tank2.Name = "tank2";
            this.tank2.Size = new System.Drawing.Size(105, 178);
            this.tank2.TabIndex = 1;
            // 
            // tank3
            // 
            this.tank3.Location = new System.Drawing.Point(391, 21);
            this.tank3.Name = "tank3";
            this.tank3.Size = new System.Drawing.Size(105, 178);
            this.tank3.TabIndex = 2;
            // 
            // tank4
            // 
            this.tank4.Location = new System.Drawing.Point(144, 21);
            this.tank4.Name = "tank4";
            this.tank4.Size = new System.Drawing.Size(105, 178);
            this.tank4.TabIndex = 3;
            // 
            // tank5
            // 
            this.tank5.Location = new System.Drawing.Point(502, 21);
            this.tank5.Name = "tank5";
            this.tank5.Size = new System.Drawing.Size(105, 178);
            this.tank5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tank 01 to 05";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tank 15 to 20";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Tank 10 to 15";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Tank 05 to 10";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(539, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(428, 205);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(305, 205);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(176, 205);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(68, 22);
            this.textBox7.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tank Liquid Temparature";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBoxSignal);
            this.groupBox5.Location = new System.Drawing.Point(375, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 190);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tank Configuration";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
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
            this.listBox1.Location = new System.Drawing.Point(76, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(104, 20);
            this.listBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select the tank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number of Tanks";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(61, 164);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 15;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1367, 550);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Alarm System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLARMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scadaSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCKNOWELEGEDALARAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scadaSystemDataSet2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tank1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSignal;
        private ScadaSystemDataSet scadaSystemDataSet;
        private System.Windows.Forms.BindingSource aLARMBindingSource;
        private ScadaSystemDataSetTableAdapters.ALARMTableAdapter aLARMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmTimeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementValueDataGridViewTextBoxColumn;
        private ScadaSystemDataSet2 scadaSystemDataSet2;
        private System.Windows.Forms.BindingSource aCKNOWELEGEDALARAMBindingSource;
        private ScadaSystemDataSet2TableAdapters.ACKNOWELEGED_ALARAMTableAdapter aCKNOWELEGED_ALARAMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn acknowledgedAlaramIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private NationalInstruments.UI.WindowsForms.Tank tank5;
        private NationalInstruments.UI.WindowsForms.Tank tank4;
        private NationalInstruments.UI.WindowsForms.Tank tank3;
        private NationalInstruments.UI.WindowsForms.Tank tank2;
        private NationalInstruments.UI.WindowsForms.Tank tank1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox8;
    }
}

