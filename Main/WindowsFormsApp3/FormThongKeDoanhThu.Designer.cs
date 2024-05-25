namespace WindowsFormsApp3
{
    partial class FormThongKeDoanhThu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songuoithueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sophongcontrongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songuoichuathanhtoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongthanhtoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongkeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLCH1DataSet = new WindowsFormsApp3.QLCH1DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.thong_keTableAdapter = new WindowsFormsApp3.QLCH1DataSetTableAdapters.Thong_keTableAdapter();
            this.thongkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thangDataGridViewTextBoxColumn,
            this.songuoithueDataGridViewTextBoxColumn,
            this.sophongcontrongDataGridViewTextBoxColumn,
            this.songuoichuathanhtoanDataGridViewTextBoxColumn,
            this.tongthanhtoanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thongkeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(138, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(854, 241);
            this.dataGridView1.TabIndex = 6;
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Tháng";
            this.thangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            this.thangDataGridViewTextBoxColumn.ReadOnly = true;
            this.thangDataGridViewTextBoxColumn.Width = 125;
            // 
            // songuoithueDataGridViewTextBoxColumn
            // 
            this.songuoithueDataGridViewTextBoxColumn.DataPropertyName = "so_nguoi_thue";
            this.songuoithueDataGridViewTextBoxColumn.HeaderText = "Số người thuê";
            this.songuoithueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.songuoithueDataGridViewTextBoxColumn.Name = "songuoithueDataGridViewTextBoxColumn";
            this.songuoithueDataGridViewTextBoxColumn.ReadOnly = true;
            this.songuoithueDataGridViewTextBoxColumn.Width = 125;
            // 
            // sophongcontrongDataGridViewTextBoxColumn
            // 
            this.sophongcontrongDataGridViewTextBoxColumn.DataPropertyName = "so_phong_con_trong";
            this.sophongcontrongDataGridViewTextBoxColumn.HeaderText = "Số phòng còn trống";
            this.sophongcontrongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sophongcontrongDataGridViewTextBoxColumn.Name = "sophongcontrongDataGridViewTextBoxColumn";
            this.sophongcontrongDataGridViewTextBoxColumn.ReadOnly = true;
            this.sophongcontrongDataGridViewTextBoxColumn.Width = 175;
            // 
            // songuoichuathanhtoanDataGridViewTextBoxColumn
            // 
            this.songuoichuathanhtoanDataGridViewTextBoxColumn.DataPropertyName = "so_nguoi_chua_thanh_toan";
            this.songuoichuathanhtoanDataGridViewTextBoxColumn.HeaderText = "Số cư dân chưa thanh toán";
            this.songuoichuathanhtoanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.songuoichuathanhtoanDataGridViewTextBoxColumn.Name = "songuoichuathanhtoanDataGridViewTextBoxColumn";
            this.songuoichuathanhtoanDataGridViewTextBoxColumn.ReadOnly = true;
            this.songuoichuathanhtoanDataGridViewTextBoxColumn.Width = 250;
            // 
            // tongthanhtoanDataGridViewTextBoxColumn
            // 
            this.tongthanhtoanDataGridViewTextBoxColumn.DataPropertyName = "tong_thanh_toan";
            this.tongthanhtoanDataGridViewTextBoxColumn.HeaderText = "Tổng thanh toán";
            this.tongthanhtoanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongthanhtoanDataGridViewTextBoxColumn.Name = "tongthanhtoanDataGridViewTextBoxColumn";
            this.tongthanhtoanDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongthanhtoanDataGridViewTextBoxColumn.Width = 175;
            // 
            // thongkeBindingSource1
            // 
            this.thongkeBindingSource1.DataMember = "Thong_ke";
            this.thongkeBindingSource1.DataSource = this.qLCH1DataSet;
            this.thongkeBindingSource1.CurrentChanged += new System.EventHandler(this.thongkeBindingSource1_CurrentChanged);
            // 
            // qLCH1DataSet
            // 
            this.qLCH1DataSet.DataSetName = "QLCH1DataSet";
            this.qLCH1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(681, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(352, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 90);
            this.label1.TabIndex = 4;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(294, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xem biểu đồ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // thong_keTableAdapter
            // 
            this.thong_keTableAdapter.ClearBeforeFill = true;
            // 
            // thongkeBindingSource
            // 
            this.thongkeBindingSource.DataMember = "Thong_ke";
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "FormThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongKeDoanhThu";
            this.Load += new System.EventHandler(this.FormThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCH1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource thongkeBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private QLCH1DataSet qLCH1DataSet;
        private System.Windows.Forms.BindingSource thongkeBindingSource1;
        private QLCH1DataSetTableAdapters.Thong_keTableAdapter thong_keTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songuoithueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophongcontrongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songuoichuathanhtoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongthanhtoanDataGridViewTextBoxColumn;
    }
}