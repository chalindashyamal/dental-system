namespace C__sample_Project
{
    partial class New_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Appointment));
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAppdate_time2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.appointmentDataSet = new C__sample_Project.AppointmentDataSet();
            this.appointmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new C__sample_Project.AppointmentDataSetTableAdapters.appointmentsTableAdapter();
            this.dental_DBDataSet = new C__sample_Project.Dental_DBDataSet();
            this.appointmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter1 = new C__sample_Project.Dental_DBDataSetTableAdapters.appointmentsTableAdapter();
            this.dental_DBDataSet1 = new C__sample_Project.Dental_DBDataSet1();
            this.appointmentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter2 = new C__sample_Project.Dental_DBDataSet1TableAdapters.appointmentsTableAdapter();
            this.dental_DBDataSet5 = new C__sample_Project.Dental_DBDataSet5();
            this.appointmentsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter3 = new C__sample_Project.Dental_DBDataSet5TableAdapters.appointmentsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_DBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAppId
            // 
            this.txtAppId.Location = new System.Drawing.Point(420, 87);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.Size = new System.Drawing.Size(270, 22);
            this.txtAppId.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Appointment DateAnd Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Patient ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(420, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 54;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAppdate_time2
            // 
            this.txtAppdate_time2.Location = new System.Drawing.Point(420, 134);
            this.txtAppdate_time2.Name = "txtAppdate_time2";
            this.txtAppdate_time2.Size = new System.Drawing.Size(270, 22);
            this.txtAppdate_time2.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(720, 344);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 28);
            this.button7.TabIndex = 79;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(720, 292);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 28);
            this.button8.TabIndex = 78;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Search From Date And Time";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(420, 347);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 22);
            this.textBox2.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Search From ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(420, 298);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 22);
            this.textBox3.TabIndex = 74;
            // 
            // appointmentDataSet
            // 
            this.appointmentDataSet.DataSetName = "AppointmentDataSet";
            this.appointmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentDataSetBindingSource
            // 
            this.appointmentDataSetBindingSource.DataSource = this.appointmentDataSet;
            this.appointmentDataSetBindingSource.Position = 0;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "appointments";
            this.appointmentsBindingSource.DataSource = this.appointmentDataSetBindingSource;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // dental_DBDataSet
            // 
            this.dental_DBDataSet.DataSetName = "Dental_DBDataSet";
            this.dental_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource1
            // 
            this.appointmentsBindingSource1.DataMember = "appointments";
            this.appointmentsBindingSource1.DataSource = this.dental_DBDataSet;
            // 
            // appointmentsTableAdapter1
            // 
            this.appointmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // dental_DBDataSet1
            // 
            this.dental_DBDataSet1.DataSetName = "Dental_DBDataSet1";
            this.dental_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource2
            // 
            this.appointmentsBindingSource2.DataMember = "appointments";
            this.appointmentsBindingSource2.DataSource = this.dental_DBDataSet1;
            // 
            // appointmentsTableAdapter2
            // 
            this.appointmentsTableAdapter2.ClearBeforeFill = true;
            // 
            // dental_DBDataSet5
            // 
            this.dental_DBDataSet5.DataSetName = "Dental_DBDataSet5";
            this.dental_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource3
            // 
            this.appointmentsBindingSource3.DataMember = "appointments";
            this.appointmentsBindingSource3.DataSource = this.dental_DBDataSet5;
            // 
            // appointmentsTableAdapter3
            // 
            this.appointmentsTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentidDataGridViewTextBoxColumn,
            this.patientidDataGridViewTextBoxColumn,
            this.dateandtimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(58, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 250);
            this.dataGridView1.TabIndex = 80;
            // 
            // appointmentidDataGridViewTextBoxColumn
            // 
            this.appointmentidDataGridViewTextBoxColumn.DataPropertyName = "appointment_id";
            this.appointmentidDataGridViewTextBoxColumn.HeaderText = "appointment_id";
            this.appointmentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentidDataGridViewTextBoxColumn.Name = "appointmentidDataGridViewTextBoxColumn";
            this.appointmentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "patient_id";
            this.patientidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            // 
            // dateandtimeDataGridViewTextBoxColumn
            // 
            this.dateandtimeDataGridViewTextBoxColumn.DataPropertyName = "date_and_time";
            this.dateandtimeDataGridViewTextBoxColumn.HeaderText = "date_and_time";
            this.dateandtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateandtimeDataGridViewTextBoxColumn.Name = "dateandtimeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // New_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 671);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAppdate_time2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAppId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "New_Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Appointment";
            this.Load += new System.EventHandler(this.New_Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_DBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtAppdate_time2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource appointmentDataSetBindingSource;
        private AppointmentDataSet appointmentDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private AppointmentDataSetTableAdapters.appointmentsTableAdapter appointmentsTableAdapter;
        private Dental_DBDataSet dental_DBDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource1;
        private Dental_DBDataSetTableAdapters.appointmentsTableAdapter appointmentsTableAdapter1;
        private Dental_DBDataSet1 dental_DBDataSet1;
        private System.Windows.Forms.BindingSource appointmentsBindingSource2;
        private Dental_DBDataSet1TableAdapters.appointmentsTableAdapter appointmentsTableAdapter2;
        private Dental_DBDataSet5 dental_DBDataSet5;
        private System.Windows.Forms.BindingSource appointmentsBindingSource3;
        private Dental_DBDataSet5TableAdapters.appointmentsTableAdapter appointmentsTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}