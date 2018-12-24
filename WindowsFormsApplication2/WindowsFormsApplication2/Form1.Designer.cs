namespace WindowsFormsApplication2
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
            this.KetQua = new System.Windows.Forms.Button();
            this.chon = new System.Windows.Forms.ComboBox();
            this.SoA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SoB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KetQua
            // 
            this.KetQua.ForeColor = System.Drawing.Color.DarkBlue;
            this.KetQua.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.KetQua.ImageKey = "(none)";
            this.KetQua.Location = new System.Drawing.Point(185, 320);
            this.KetQua.Margin = new System.Windows.Forms.Padding(4);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(245, 35);
            this.KetQua.TabIndex = 3;
            this.KetQua.Text = "Kết quả";
            this.KetQua.UseVisualStyleBackColor = true;
            this.KetQua.Click += new System.EventHandler(this.KetQua_Click_1);
            // 
            // chon
            // 
            this.chon.FormattingEnabled = true;
            this.chon.Items.AddRange(new object[] {
            "Cộng",
            "Trừ",
            "Nhân",
            "Chia"});
            this.chon.Location = new System.Drawing.Point(185, 272);
            this.chon.Margin = new System.Windows.Forms.Padding(4);
            this.chon.Name = "chon";
            this.chon.Size = new System.Drawing.Size(244, 28);
            this.chon.TabIndex = 2;
            // 
            // SoA
            // 
            this.SoA.AcceptsTab = true;
            this.SoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoA.Location = new System.Drawing.Point(185, 105);
            this.SoA.Margin = new System.Windows.Forms.Padding(4);
            this.SoA.MaxLength = 32769;
            this.SoA.Multiline = true;
            this.SoA.Name = "SoA";
            this.SoA.Size = new System.Drawing.Size(244, 24);
            this.SoA.TabIndex = 0;
            this.SoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::WindowsFormsApplication2.Properties.Resources.Haivl;
            this.label1.Location = new System.Drawing.Point(61, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập a";
            // 
            // SoB
            // 
            this.SoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoB.Location = new System.Drawing.Point(185, 165);
            this.SoB.Margin = new System.Windows.Forms.Padding(4);
            this.SoB.Multiline = true;
            this.SoB.Name = "SoB";
            this.SoB.Size = new System.Drawing.Size(245, 24);
            this.SoB.TabIndex = 1;
            this.SoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Image = global::WindowsFormsApplication2.Properties.Resources.Haivl;
            this.label2.Location = new System.Drawing.Point(61, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(178, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hello World";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.KetQua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources._400_d42e0230_cbcc_4fec_99f1_d1662013808f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(528, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SoB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoA);
            this.Controls.Add(this.chon);
            this.Controls.Add(this.KetQua);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Tính Toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox chon;
        private System.Windows.Forms.TextBox SoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SoB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button KetQua;
    }
}

