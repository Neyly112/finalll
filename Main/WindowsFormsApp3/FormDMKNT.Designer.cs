namespace WindowsFormsApp3
{
    partial class FormDMKNT
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbMkMoi = new WindowsFormsApp3.UI.UserControlBTN();
            this.tbMkCu = new WindowsFormsApp3.UI.UserControlBTN();
            this.tbXacNhan = new WindowsFormsApp3.UI.UserControlBTN();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(418, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 45);
            this.button1.TabIndex = 27;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gold;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.Location = new System.Drawing.Point(212, 425);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 45);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(44, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 37);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(44, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(327, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.logo3;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // tbMkMoi
            // 
            this.tbMkMoi.BackColor = System.Drawing.SystemColors.Window;
            this.tbMkMoi.BorderColor = System.Drawing.Color.DarkKhaki;
            this.tbMkMoi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbMkMoi.BorderSize = 5;
            this.tbMkMoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMkMoi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbMkMoi.Location = new System.Drawing.Point(354, 260);
            this.tbMkMoi.Margin = new System.Windows.Forms.Padding(4);
            this.tbMkMoi.Multiline = false;
            this.tbMkMoi.Name = "tbMkMoi";
            this.tbMkMoi.Padding = new System.Windows.Forms.Padding(7);
            this.tbMkMoi.PasswordChar = false;
            this.tbMkMoi.Size = new System.Drawing.Size(349, 41);
            this.tbMkMoi.TabIndex = 99;
            this.tbMkMoi.Texts = "";
            this.tbMkMoi.UnderlinedStyle = true;
            // 
            // tbMkCu
            // 
            this.tbMkCu.BackColor = System.Drawing.SystemColors.Window;
            this.tbMkCu.BorderColor = System.Drawing.Color.DarkKhaki;
            this.tbMkCu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbMkCu.BorderSize = 5;
            this.tbMkCu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMkCu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbMkCu.Location = new System.Drawing.Point(354, 168);
            this.tbMkCu.Margin = new System.Windows.Forms.Padding(4);
            this.tbMkCu.Multiline = false;
            this.tbMkCu.Name = "tbMkCu";
            this.tbMkCu.Padding = new System.Windows.Forms.Padding(7);
            this.tbMkCu.PasswordChar = false;
            this.tbMkCu.Size = new System.Drawing.Size(349, 41);
            this.tbMkCu.TabIndex = 98;
            this.tbMkCu.Texts = "";
            this.tbMkCu.UnderlinedStyle = true;
            // 
            // tbXacNhan
            // 
            this.tbXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbXacNhan.BackColor = System.Drawing.SystemColors.Window;
            this.tbXacNhan.BorderColor = System.Drawing.Color.DarkKhaki;
            this.tbXacNhan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbXacNhan.BorderSize = 5;
            this.tbXacNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbXacNhan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbXacNhan.Location = new System.Drawing.Point(354, 345);
            this.tbXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.tbXacNhan.Multiline = false;
            this.tbXacNhan.Name = "tbXacNhan";
            this.tbXacNhan.Padding = new System.Windows.Forms.Padding(7);
            this.tbXacNhan.PasswordChar = false;
            this.tbXacNhan.Size = new System.Drawing.Size(349, 41);
            this.tbXacNhan.TabIndex = 101;
            this.tbXacNhan.Texts = "";
            this.tbXacNhan.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(44, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 37);
            this.label4.TabIndex = 100;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // FormDMKNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(812, 503);
            this.Controls.Add(this.tbXacNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMkMoi);
            this.Controls.Add(this.tbMkCu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDMKNT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDMKNT";
            this.Load += new System.EventHandler(this.FormDMKNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UI.UserControlBTN tbMkMoi;
        private UI.UserControlBTN tbMkCu;
        private UI.UserControlBTN tbXacNhan;
        private System.Windows.Forms.Label label4;
    }
}