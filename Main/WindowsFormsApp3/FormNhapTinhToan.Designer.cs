namespace WindowsFormsApp3
{
    partial class FormNhapTinhToan
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ngayKetThuc = new WindowsFormsApp3.UI.DatePicker();
            this.ngayBatDau = new WindowsFormsApp3.UI.DatePicker();
            this.tbTienDien = new System.Windows.Forms.TextBox();
            this.tbTienNuoc = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(194, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 37);
            this.label7.TabIndex = 35;
            this.label7.Text = "Đến ngày";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(194, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 37);
            this.label6.TabIndex = 34;
            this.label6.Text = "Từ ngày";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(443, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 59);
            this.button2.TabIndex = 33;
            this.button2.Text = "Tính tổng tiền";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(251, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 59);
            this.button1.TabIndex = 32;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(194, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số m3 nước";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(194, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "Số kwh";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(194, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên phòng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(326, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 49);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nhập các số liệu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.logo3;
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngayKetThuc.BorderColor = System.Drawing.Color.DarkKhaki;
            this.ngayKetThuc.BorderSize = 1;
            this.ngayKetThuc.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F);
            this.ngayKetThuc.CustomFormat = "yyyy-MM-dd";
            this.ngayKetThuc.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.ngayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayKetThuc.Location = new System.Drawing.Point(417, 377);
            this.ngayKetThuc.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.ngayKetThuc.MinimumSize = new System.Drawing.Size(4, 35);
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Size = new System.Drawing.Size(300, 39);
            this.ngayKetThuc.SkinColor = System.Drawing.SystemColors.ControlLight;
            this.ngayKetThuc.TabIndex = 41;
            this.ngayKetThuc.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngayBatDau.BorderColor = System.Drawing.Color.DarkKhaki;
            this.ngayBatDau.BorderSize = 1;
            this.ngayBatDau.CalendarFont = new System.Drawing.Font("Times New Roman", 16.2F);
            this.ngayBatDau.CustomFormat = "yyyy-MM-dd";
            this.ngayBatDau.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.ngayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayBatDau.Location = new System.Drawing.Point(417, 321);
            this.ngayBatDau.MinDate = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.ngayBatDau.MinimumSize = new System.Drawing.Size(4, 35);
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.Size = new System.Drawing.Size(300, 39);
            this.ngayBatDau.SkinColor = System.Drawing.SystemColors.ControlLight;
            this.ngayBatDau.TabIndex = 39;
            this.ngayBatDau.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbTienDien
            // 
            this.tbTienDien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTienDien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTienDien.Location = new System.Drawing.Point(417, 204);
            this.tbTienDien.Multiline = true;
            this.tbTienDien.Name = "tbTienDien";
            this.tbTienDien.Size = new System.Drawing.Size(300, 37);
            this.tbTienDien.TabIndex = 45;
            this.tbTienDien.TextChanged += new System.EventHandler(this.tbTienDien_TextChanged);
            this.tbTienDien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbTienNuoc
            // 
            this.tbTienNuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTienNuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.tbTienNuoc.Location = new System.Drawing.Point(417, 264);
            this.tbTienNuoc.Multiline = true;
            this.tbTienNuoc.Name = "tbTienNuoc";
            this.tbTienNuoc.Size = new System.Drawing.Size(300, 37);
            this.tbTienNuoc.TabIndex = 46;
            this.tbTienNuoc.TextChanged += new System.EventHandler(this.tbTienNuoc_TextChanged);
            this.tbTienNuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTienNuoc_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(417, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 39);
            this.comboBox1.TabIndex = 47;
            // 
            // FormNhapTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(904, 569);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbTienNuoc);
            this.Controls.Add(this.tbTienDien);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ngayKetThuc);
            this.Controls.Add(this.ngayBatDau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(922, 616);
            this.Name = "FormNhapTinhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhapTinhToan";
            this.Load += new System.EventHandler(this.FormNhapTinhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UI.DatePicker ngayBatDau;
        private UI.DatePicker ngayKetThuc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbTienDien;
        private System.Windows.Forms.TextBox tbTienNuoc;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}