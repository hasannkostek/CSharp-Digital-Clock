namespace Dijital_Saat_Uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelZaman = new System.Windows.Forms.Label();
            this.timerZaman = new System.Windows.Forms.Timer(this.components);
            this.labelYıl = new System.Windows.Forms.Label();
            this.labelAy = new System.Windows.Forms.Label();
            this.labelGun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelZaman
            // 
            this.labelZaman.AutoSize = true;
            this.labelZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelZaman.Location = new System.Drawing.Point(68, 28);
            this.labelZaman.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelZaman.Name = "labelZaman";
            this.labelZaman.Size = new System.Drawing.Size(255, 91);
            this.labelZaman.TabIndex = 0;
            this.labelZaman.Text = "label1";
            // 
            // timerZaman
            // 
            this.timerZaman.Enabled = true;
            this.timerZaman.Interval = 1000;
            this.timerZaman.Tick += new System.EventHandler(this.timerZaman_Tick);
            // 
            // labelYıl
            // 
            this.labelYıl.AutoSize = true;
            this.labelYıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYıl.Location = new System.Drawing.Point(72, 146);
            this.labelYıl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelYıl.Name = "labelYıl";
            this.labelYıl.Size = new System.Drawing.Size(123, 69);
            this.labelYıl.TabIndex = 1;
            this.labelYıl.Text = "YIL";
            // 
            // labelAy
            // 
            this.labelAy.AutoSize = true;
            this.labelAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAy.Location = new System.Drawing.Point(240, 146);
            this.labelAy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAy.Name = "labelAy";
            this.labelAy.Size = new System.Drawing.Size(112, 69);
            this.labelAy.TabIndex = 2;
            this.labelAy.Text = "AY";
            // 
            // labelGun
            // 
            this.labelGun.AutoSize = true;
            this.labelGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGun.Location = new System.Drawing.Point(402, 146);
            this.labelGun.Name = "labelGun";
            this.labelGun.Size = new System.Drawing.Size(166, 69);
            this.labelGun.TabIndex = 3;
            this.labelGun.Text = "GÜN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 475);
            this.Controls.Add(this.labelGun);
            this.Controls.Add(this.labelAy);
            this.Controls.Add(this.labelYıl);
            this.Controls.Add(this.labelZaman);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZaman;
        private System.Windows.Forms.Timer timerZaman;
        private System.Windows.Forms.Label labelYıl;
        private System.Windows.Forms.Label labelAy;
        private System.Windows.Forms.Label labelGun;
    }
}

