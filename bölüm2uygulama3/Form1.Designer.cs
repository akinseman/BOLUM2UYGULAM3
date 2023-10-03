namespace bölüm2uygulama3
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
            this.lblsayı1 = new System.Windows.Forms.Label();
            this.lblSayı2 = new System.Windows.Forms.Label();
            this.txtsayı1 = new System.Windows.Forms.TextBox();
            this.txtsayı2 = new System.Windows.Forms.TextBox();
            this.btnKarlıstırma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsayı1
            // 
            this.lblsayı1.AutoSize = true;
            this.lblsayı1.Location = new System.Drawing.Point(12, 19);
            this.lblsayı1.Name = "lblsayı1";
            this.lblsayı1.Size = new System.Drawing.Size(70, 13);
            this.lblsayı1.TabIndex = 0;
            this.lblsayı1.Text = "1  Sayı Giriniz";
            // 
            // lblSayı2
            // 
            this.lblSayı2.AutoSize = true;
            this.lblSayı2.Location = new System.Drawing.Point(12, 60);
            this.lblSayı2.Name = "lblSayı2";
            this.lblSayı2.Size = new System.Drawing.Size(67, 13);
            this.lblSayı2.TabIndex = 1;
            this.lblSayı2.Text = "2 Sayı Giriniz";
            // 
            // txtsayı1
            // 
            this.txtsayı1.Location = new System.Drawing.Point(110, 12);
            this.txtsayı1.Name = "txtsayı1";
            this.txtsayı1.Size = new System.Drawing.Size(100, 20);
            this.txtsayı1.TabIndex = 2;
            // 
            // txtsayı2
            // 
            this.txtsayı2.Location = new System.Drawing.Point(110, 60);
            this.txtsayı2.Name = "txtsayı2";
            this.txtsayı2.Size = new System.Drawing.Size(100, 20);
            this.txtsayı2.TabIndex = 3;
            // 
            // btnKarlıstırma
            // 
            this.btnKarlıstırma.Location = new System.Drawing.Point(43, 117);
            this.btnKarlıstırma.Name = "btnKarlıstırma";
            this.btnKarlıstırma.Size = new System.Drawing.Size(156, 51);
            this.btnKarlıstırma.TabIndex = 4;
            this.btnKarlıstırma.Text = "Kartılışma";
            this.btnKarlıstırma.UseVisualStyleBackColor = true;
            this.btnKarlıstırma.Click += new System.EventHandler(this.btnKarlıstırma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 180);
            this.Controls.Add(this.btnKarlıstırma);
            this.Controls.Add(this.txtsayı2);
            this.Controls.Add(this.txtsayı1);
            this.Controls.Add(this.lblSayı2);
            this.Controls.Add(this.lblsayı1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsayı1;
        private System.Windows.Forms.Label lblSayı2;
        private System.Windows.Forms.TextBox txtsayı1;
        private System.Windows.Forms.TextBox txtsayı2;
        private System.Windows.Forms.Button btnKarlıstırma;
    }
}

