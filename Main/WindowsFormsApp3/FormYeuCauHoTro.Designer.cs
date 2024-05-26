namespace WindowsFormsApp3
{
    partial class FormYeuCauHoTro
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
            this.tin_nhanTableAdapter = new WindowsFormsApp3.QLCH2DataSetTableAdapters.Tin_nhanTableAdapter();
            this.tinnhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCH2DataSet = new WindowsFormsApp3.QLCH2DataSet();
            this.tinnhanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tinnhanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLCH2DataSet1 = new WindowsFormsApp3.QLCH2DataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tin_nhanTableAdapter1 = new WindowsFormsApp3.QLCH2DataSet1TableAdapters.Tin_nhanTableAdapter();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tinnhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinnhanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinnhanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tin_nhanTableAdapter
            // 
            this.tin_nhanTableAdapter.ClearBeforeFill = true;
            // 
            // tinnhanBindingSource
            // 
            this.tinnhanBindingSource.DataMember = "Tin_nhan";
            this.tinnhanBindingSource.DataSource = this.qLCH2DataSet;
            // 
            // qLCH2DataSet
            // 
            this.qLCH2DataSet.DataSetName = "QLCH2DataSet";
            this.qLCH2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tinnhanBindingSource1
            // 
            this.tinnhanBindingSource1.DataMember = "Tin_nhan";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(932, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 49);
            this.button3.TabIndex = 54;
            this.button3.Text = "Xem lịch sử tin nhắn ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.senderDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.sentDateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tinnhanBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(923, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(617, 222);
            this.dataGridView1.TabIndex = 53;
            // 
            // tinnhanBindingSource2
            // 
            this.tinnhanBindingSource2.DataMember = "Tin_nhan";
            this.tinnhanBindingSource2.DataSource = this.qLCH2DataSet1;
            // 
            // qLCH2DataSet1
            // 
            this.qLCH2DataSet1.DataSetName = "QLCH2DataSet1";
            this.qLCH2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(925, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 37);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tin nhắn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(602, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 24);
            this.comboBox1.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(595, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 37);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mã quản lý";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(602, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 49);
            this.button2.TabIndex = 49;
            this.button2.Text = "Xem tin nhắn mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 37);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nhập tin nhắn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(542, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 100);
            this.label1.TabIndex = 46;
            this.label1.Text = "YÊU CẦU HỖ TRỢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(45, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 45;
            this.button1.Text = "Gửi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(45, 226);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 99);
            this.textBox1.TabIndex = 44;
            // 
            // tin_nhanTableAdapter1
            // 
            this.tin_nhanTableAdapter1.ClearBeforeFill = true;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "Người gửi";
            this.senderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            this.senderDataGridViewTextBoxColumn.Width = 275;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.contentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.Width = 275;
            // 
            // sentDateTimeDataGridViewTextBoxColumn
            // 
            this.sentDateTimeDataGridViewTextBoxColumn.DataPropertyName = "SentDateTime";
            this.sentDateTimeDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.sentDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sentDateTimeDataGridViewTextBoxColumn.Name = "sentDateTimeDataGridViewTextBoxColumn";
            this.sentDateTimeDataGridViewTextBoxColumn.Width = 275;
            // 
            // FormYeuCauHoTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "FormYeuCauHoTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormYeuCauHoTro";
            this.Load += new System.EventHandler(this.FormYeuCauHoTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tinnhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinnhanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinnhanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLCH2DataSetTableAdapters.Tin_nhanTableAdapter tin_nhanTableAdapter;
        private System.Windows.Forms.BindingSource tinnhanBindingSource;
        private QLCH2DataSet qLCH2DataSet;
        private System.Windows.Forms.BindingSource tinnhanBindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private QLCH2DataSet1 qLCH2DataSet1;
        private System.Windows.Forms.BindingSource tinnhanBindingSource2;
        private QLCH2DataSet1TableAdapters.Tin_nhanTableAdapter tin_nhanTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentDateTimeDataGridViewTextBoxColumn;
    }
}