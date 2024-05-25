namespace WindowsFormsApp3
{
    partial class FormDKX
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bienSoXe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.RadioButton();
            this.bt1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(166, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 46);
            this.label2.TabIndex = 57;
            this.label2.Text = "ĐĂNG KÝ GỬI XE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(202, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(238, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 82;
            this.label4.Text = "Thoát";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // bienSoXe
            // 
            this.bienSoXe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.bienSoXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bienSoXe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienSoXe.ForeColor = System.Drawing.Color.Black;
            this.bienSoXe.Location = new System.Drawing.Point(103, 396);
            this.bienSoXe.Multiline = true;
            this.bienSoXe.Name = "bienSoXe";
            this.bienSoXe.Size = new System.Drawing.Size(332, 41);
            this.bienSoXe.TabIndex = 81;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(103, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 36);
            this.button1.TabIndex = 80;
            this.button1.Text = "XÁC NHẬN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt3
            // 
            this.bt3.AutoSize = true;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.bt3.Location = new System.Drawing.Point(214, 300);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(141, 24);
            this.bt3.TabIndex = 86;
            this.bt3.TabStop = true;
            this.bt3.Text = "Xe dưới 1.5 tấn";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.CheckedChanged += new System.EventHandler(this.bt3_CheckedChanged);
            // 
            // bt1
            // 
            this.bt1.AutoSize = true;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(214, 262);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(86, 24);
            this.bt1.TabIndex = 85;
            this.bt1.TabStop = true;
            this.bt1.Text = "Xe máy";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.CheckedChanged += new System.EventHandler(this.bt1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(196, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 34);
            this.label5.TabIndex = 84;
            this.label5.Text = "Nhập biển số xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(196, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 34);
            this.label3.TabIndex = 83;
            this.label3.Text = "Chọn loại xe";
            // 
            // FormDKX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 601);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bienSoXe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormDKX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDKX";
            this.Load += new System.EventHandler(this.FormDKX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bienSoXe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton bt3;
        private System.Windows.Forms.RadioButton bt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}