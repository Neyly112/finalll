namespace WindowsFormsApp3
{
    partial class FormTraCuuPhi
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tienNuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phiSinhHoatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienDienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienXeMayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienXeDapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienXeDuoi15TanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBangPhiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChuHoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maQuanLiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bangphiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCH2DataSet2 = new WindowsFormsApp3.QLCH2DataSet2();
            this.bang_phiTableAdapter = new WindowsFormsApp3.QLCH2DataSet2TableAdapters.Bang_phiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangphiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH2DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 100);
            this.label1.TabIndex = 24;
            this.label1.Text = "TRA CỨU PHÍ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 26);
            this.label3.TabIndex = 51;
            this.label3.Text = "Danh sách phòng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 53;
            this.label4.Text = "Mã hóa đơn";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(200, 270);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 24);
            this.comboBox2.TabIndex = 54;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(719, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 55;
            this.label5.Text = "Bảng phí";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tienNuocDataGridViewTextBoxColumn,
            this.phiSinhHoatDataGridViewTextBoxColumn,
            this.tienDienDataGridViewTextBoxColumn,
            this.tienXeMayDataGridViewTextBoxColumn,
            this.tienXeDapDataGridViewTextBoxColumn,
            this.tienXeDuoi15TanDataGridViewTextBoxColumn,
            this.maBangPhiDataGridViewTextBoxColumn,
            this.maChuHoDataGridViewTextBoxColumn,
            this.maQuanLiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bangphiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(724, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(692, 312);
            this.dataGridView1.TabIndex = 56;
            // 
            // tienNuocDataGridViewTextBoxColumn
            // 
            this.tienNuocDataGridViewTextBoxColumn.DataPropertyName = "TienNuoc";
            this.tienNuocDataGridViewTextBoxColumn.HeaderText = "Tiền nước";
            this.tienNuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienNuocDataGridViewTextBoxColumn.Name = "tienNuocDataGridViewTextBoxColumn";
            this.tienNuocDataGridViewTextBoxColumn.Width = 125;
            // 
            // phiSinhHoatDataGridViewTextBoxColumn
            // 
            this.phiSinhHoatDataGridViewTextBoxColumn.DataPropertyName = "PhiSinhHoat";
            this.phiSinhHoatDataGridViewTextBoxColumn.HeaderText = "Phí sinh hoạt";
            this.phiSinhHoatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phiSinhHoatDataGridViewTextBoxColumn.Name = "phiSinhHoatDataGridViewTextBoxColumn";
            this.phiSinhHoatDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienDienDataGridViewTextBoxColumn
            // 
            this.tienDienDataGridViewTextBoxColumn.DataPropertyName = "TienDien";
            this.tienDienDataGridViewTextBoxColumn.HeaderText = "Tiền điện";
            this.tienDienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienDienDataGridViewTextBoxColumn.Name = "tienDienDataGridViewTextBoxColumn";
            this.tienDienDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienXeMayDataGridViewTextBoxColumn
            // 
            this.tienXeMayDataGridViewTextBoxColumn.DataPropertyName = "TienXeMay";
            this.tienXeMayDataGridViewTextBoxColumn.HeaderText = "Tiền xe máy";
            this.tienXeMayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienXeMayDataGridViewTextBoxColumn.Name = "tienXeMayDataGridViewTextBoxColumn";
            this.tienXeMayDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienXeDapDataGridViewTextBoxColumn
            // 
            this.tienXeDapDataGridViewTextBoxColumn.DataPropertyName = "TienXeDap";
            this.tienXeDapDataGridViewTextBoxColumn.HeaderText = "Tiền xe đạp";
            this.tienXeDapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienXeDapDataGridViewTextBoxColumn.Name = "tienXeDapDataGridViewTextBoxColumn";
            this.tienXeDapDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienXeDuoi15TanDataGridViewTextBoxColumn
            // 
            this.tienXeDuoi15TanDataGridViewTextBoxColumn.DataPropertyName = "TienXeDuoi1_5Tan";
            this.tienXeDuoi15TanDataGridViewTextBoxColumn.HeaderText = "Tiền xe dưới 1,5 tấn";
            this.tienXeDuoi15TanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienXeDuoi15TanDataGridViewTextBoxColumn.Name = "tienXeDuoi15TanDataGridViewTextBoxColumn";
            this.tienXeDuoi15TanDataGridViewTextBoxColumn.Width = 125;
            // 
            // maBangPhiDataGridViewTextBoxColumn
            // 
            this.maBangPhiDataGridViewTextBoxColumn.DataPropertyName = "MaBangPhi";
            this.maBangPhiDataGridViewTextBoxColumn.HeaderText = "Mã bảng phí";
            this.maBangPhiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maBangPhiDataGridViewTextBoxColumn.Name = "maBangPhiDataGridViewTextBoxColumn";
            this.maBangPhiDataGridViewTextBoxColumn.Width = 125;
            // 
            // maChuHoDataGridViewTextBoxColumn
            // 
            this.maChuHoDataGridViewTextBoxColumn.DataPropertyName = "MaChuHo";
            this.maChuHoDataGridViewTextBoxColumn.HeaderText = "Mã chủ hộ";
            this.maChuHoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maChuHoDataGridViewTextBoxColumn.Name = "maChuHoDataGridViewTextBoxColumn";
            this.maChuHoDataGridViewTextBoxColumn.Width = 125;
            // 
            // maQuanLiDataGridViewTextBoxColumn
            // 
            this.maQuanLiDataGridViewTextBoxColumn.DataPropertyName = "MaQuanLi";
            this.maQuanLiDataGridViewTextBoxColumn.HeaderText = "Mã quản lí";
            this.maQuanLiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maQuanLiDataGridViewTextBoxColumn.Name = "maQuanLiDataGridViewTextBoxColumn";
            this.maQuanLiDataGridViewTextBoxColumn.Width = 125;
            // 
            // bangphiBindingSource
            // 
            this.bangphiBindingSource.DataMember = "Bang_phi";
            this.bangphiBindingSource.DataSource = this.qLCH2DataSet2;
            // 
            // qLCH2DataSet2
            // 
            this.qLCH2DataSet2.DataSetName = "QLCH2DataSet2";
            this.qLCH2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bang_phiTableAdapter
            // 
            this.bang_phiTableAdapter.ClearBeforeFill = true;
            // 
            // FormTraCuuPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormTraCuuPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTraCuuPhi";
            this.Load += new System.EventHandler(this.FormTraCuuPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangphiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH2DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLCH2DataSet2 qLCH2DataSet2;
        private System.Windows.Forms.BindingSource bangphiBindingSource;
        private QLCH2DataSet2TableAdapters.Bang_phiTableAdapter bang_phiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienNuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phiSinhHoatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienDienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienXeMayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienXeDapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienXeDuoi15TanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBangPhiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuHoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQuanLiDataGridViewTextBoxColumn;
    }
}