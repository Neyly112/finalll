namespace WindowsFormsApp3
{
    partial class FormCTHDCHUHO
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hoa_Don_Tien_Nuoc = new System.Windows.Forms.Button();
            this.Hoa_Don_Tien__Gui_Xe = new System.Windows.Forms.Button();
            this.Hoa_Don_Tien_Dien = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(400, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 49);
            this.label2.TabIndex = 35;
            this.label2.Text = "Hóa đơn";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(73, 360);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 55);
            this.button3.TabIndex = 34;
            this.button3.Text = "Phí Sinh hoạt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button2.Location = new System.Drawing.Point(73, 308);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 48);
            this.button2.TabIndex = 33;
            this.button2.Text = "Tiền phòng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(536, 266);
            this.dataGridView1.TabIndex = 31;
            // 
            // Hoa_Don_Tien_Nuoc
            // 
            this.Hoa_Don_Tien_Nuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Hoa_Don_Tien_Nuoc.Location = new System.Drawing.Point(73, 203);
            this.Hoa_Don_Tien_Nuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hoa_Don_Tien_Nuoc.Name = "Hoa_Don_Tien_Nuoc";
            this.Hoa_Don_Tien_Nuoc.Size = new System.Drawing.Size(163, 48);
            this.Hoa_Don_Tien_Nuoc.TabIndex = 30;
            this.Hoa_Don_Tien_Nuoc.Text = "Tiền nước";
            this.Hoa_Don_Tien_Nuoc.UseVisualStyleBackColor = true;
            this.Hoa_Don_Tien_Nuoc.Click += new System.EventHandler(this.Hoa_Don_Tien_Nuoc_Click);
            // 
            // Hoa_Don_Tien__Gui_Xe
            // 
            this.Hoa_Don_Tien__Gui_Xe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Hoa_Don_Tien__Gui_Xe.Location = new System.Drawing.Point(73, 255);
            this.Hoa_Don_Tien__Gui_Xe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hoa_Don_Tien__Gui_Xe.Name = "Hoa_Don_Tien__Gui_Xe";
            this.Hoa_Don_Tien__Gui_Xe.Size = new System.Drawing.Size(163, 49);
            this.Hoa_Don_Tien__Gui_Xe.TabIndex = 29;
            this.Hoa_Don_Tien__Gui_Xe.Text = "Tiền gửi xe";
            this.Hoa_Don_Tien__Gui_Xe.UseVisualStyleBackColor = true;
            this.Hoa_Don_Tien__Gui_Xe.Click += new System.EventHandler(this.Hoa_Don_Tien__Gui_Xe_Click);
            // 
            // Hoa_Don_Tien_Dien
            // 
            this.Hoa_Don_Tien_Dien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Hoa_Don_Tien_Dien.Location = new System.Drawing.Point(73, 149);
            this.Hoa_Don_Tien_Dien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hoa_Don_Tien_Dien.Name = "Hoa_Don_Tien_Dien";
            this.Hoa_Don_Tien_Dien.Size = new System.Drawing.Size(163, 50);
            this.Hoa_Don_Tien_Dien.TabIndex = 28;
            this.Hoa_Don_Tien_Dien.Text = "Tiền điện";
            this.Hoa_Don_Tien_Dien.UseVisualStyleBackColor = true;
            this.Hoa_Don_Tien_Dien.Click += new System.EventHandler(this.Hoa_Don_Tien_Dien_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(675, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 55);
            this.button1.TabIndex = 36;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCTHDCHUHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(910, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Hoa_Don_Tien_Nuoc);
            this.Controls.Add(this.Hoa_Don_Tien__Gui_Xe);
            this.Controls.Add(this.Hoa_Don_Tien_Dien);
            this.MinimumSize = new System.Drawing.Size(928, 603);
            this.Name = "FormCTHDCHUHO";
            this.Text = "FormCTHDCHUHO";
            this.Load += new System.EventHandler(this.FormCTHDCHUHO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Hoa_Don_Tien_Nuoc;
        private System.Windows.Forms.Button Hoa_Don_Tien__Gui_Xe;
        private System.Windows.Forms.Button Hoa_Don_Tien_Dien;
        private System.Windows.Forms.Button button1;
    }
}