namespace arastirmaodev_836
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
            this.lbSayi = new System.Windows.Forms.ListBox();
            this.btnİlk = new System.Windows.Forms.Button();
            this.btnSon = new System.Windows.Forms.Button();
            this.btnKucuk = new System.Windows.Forms.Button();
            this.btnBuyuk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSayi
            // 
            this.lbSayi.FormattingEnabled = true;
            this.lbSayi.Location = new System.Drawing.Point(12, 12);
            this.lbSayi.Name = "lbSayi";
            this.lbSayi.Size = new System.Drawing.Size(184, 316);
            this.lbSayi.TabIndex = 0;
            // 
            // btnİlk
            // 
            this.btnİlk.Location = new System.Drawing.Point(269, 12);
            this.btnİlk.Name = "btnİlk";
            this.btnİlk.Size = new System.Drawing.Size(132, 109);
            this.btnİlk.TabIndex = 1;
            this.btnİlk.Text = "İlk sayi";
            this.btnİlk.UseVisualStyleBackColor = true;
            this.btnİlk.Click += new System.EventHandler(this.btnİlk_Click);
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(269, 192);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(132, 112);
            this.btnSon.TabIndex = 2;
            this.btnSon.Text = "son sayı";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // btnKucuk
            // 
            this.btnKucuk.Location = new System.Drawing.Point(512, 13);
            this.btnKucuk.Name = "btnKucuk";
            this.btnKucuk.Size = new System.Drawing.Size(134, 108);
            this.btnKucuk.TabIndex = 3;
            this.btnKucuk.Text = "en küçük";
            this.btnKucuk.UseVisualStyleBackColor = true;
            this.btnKucuk.Click += new System.EventHandler(this.btnKucuk_Click);
            // 
            // btnBuyuk
            // 
            this.btnBuyuk.Location = new System.Drawing.Point(512, 192);
            this.btnBuyuk.Name = "btnBuyuk";
            this.btnBuyuk.Size = new System.Drawing.Size(134, 112);
            this.btnBuyuk.TabIndex = 4;
            this.btnBuyuk.Text = "En büyük";
            this.btnBuyuk.UseVisualStyleBackColor = true;
            this.btnBuyuk.Click += new System.EventHandler(this.btnBuyuk_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 94);
            this.button1.TabIndex = 5;
            this.button1.Text = "arananı sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 94);
            this.button2.TabIndex = 6;
            this.button2.Text = "sıradakini sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 104);
            this.button3.TabIndex = 7;
            this.button3.Text = "tümünü sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(434, 417);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuyuk);
            this.Controls.Add(this.btnKucuk);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.btnİlk);
            this.Controls.Add(this.lbSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayi;
        private System.Windows.Forms.Button btnİlk;
        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Button btnKucuk;
        private System.Windows.Forms.Button btnBuyuk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

