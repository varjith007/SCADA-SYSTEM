namespace control_system_temparature
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.scadaSystemDataSet = new control_system_temparature.ScadaSystemDataSet();
            this.aLARMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLARMTableAdapter = new control_system_temparature.ScadaSystemDataSetTableAdapters.ALARMTableAdapter();
            this.scadaSystemDataSet1 = new control_system_temparature.ScadaSystemDataSet1();
            this.mEASUREMENTDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEASUREMENTDATATableAdapter = new control_system_temparature.ScadaSystemDataSet1TableAdapters.MEASUREMENTDATATableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alarmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmTimeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scadaSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLARMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scadaSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEASUREMENTDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.mEASUREMENTDATABindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(773, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Temparature";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(532, 304);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Temparature";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(11, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(734, 228);
            this.listBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 265);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active Alaram";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(1, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 269);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acknowledged Alarm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(782, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 215);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Average Temparature";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(310, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min Temparature";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(310, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // scadaSystemDataSet
            // 
            this.scadaSystemDataSet.DataSetName = "ScadaSystemDataSet";
            this.scadaSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLARMBindingSource
            // 
            this.aLARMBindingSource.DataMember = "ALARM";
            this.aLARMBindingSource.DataSource = this.scadaSystemDataSet;
            // 
            // aLARMTableAdapter
            // 
            this.aLARMTableAdapter.ClearBeforeFill = true;
            // 
            // scadaSystemDataSet1
            // 
            this.scadaSystemDataSet1.DataSetName = "ScadaSystemDataSet1";
            this.scadaSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEASUREMENTDATABindingSource
            // 
            this.mEASUREMENTDATABindingSource.DataMember = "MEASUREMENTDATA";
            this.mEASUREMENTDATABindingSource.DataSource = this.scadaSystemDataSet1;
            // 
            // mEASUREMENTDATATableAdapter
            // 
            this.mEASUREMENTDATATableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 238);
            this.dataGridView1.TabIndex = 0;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1317, 545);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Alaram System";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scadaSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLARMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scadaSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEASUREMENTDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private ScadaSystemDataSet scadaSystemDataSet;
        private System.Windows.Forms.BindingSource aLARMBindingSource;
        private ScadaSystemDataSetTableAdapters.ALARMTableAdapter aLARMTableAdapter;
        private ScadaSystemDataSet1 scadaSystemDataSet1;
        private System.Windows.Forms.BindingSource mEASUREMENTDATABindingSource;
        private ScadaSystemDataSet1TableAdapters.MEASUREMENTDATATableAdapter mEASUREMENTDATATableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmTimeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementValueDataGridViewTextBoxColumn;
    }
}