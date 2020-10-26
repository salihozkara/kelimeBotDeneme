namespace text_bot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Label();
            this.zaman = new System.Windows.Forms.NumericUpDown();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.btndurdur = new System.Windows.Forms.Button();
            this.sayma = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btndevam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zaman)).BeginInit();
            this.SuspendLayout();
            // 
            // metin
            // 
            this.metin.Location = new System.Drawing.Point(140, 79);
            this.metin.Name = "metin";
            this.metin.Size = new System.Drawing.Size(138, 22);
            this.metin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tekrarlanacak\n    metin";
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Location = new System.Drawing.Point(26, 164);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(84, 17);
            this.sure.TabIndex = 2;
            this.sure.Text = "aralık süresi";
            // 
            // zaman
            // 
            this.zaman.DecimalPlaces = 1;
            this.zaman.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.zaman.Location = new System.Drawing.Point(140, 159);
            this.zaman.Name = "zaman";
            this.zaman.Size = new System.Drawing.Size(79, 22);
            this.zaman.TabIndex = 3;
            this.zaman.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // btnbaslat
            // 
            this.btnbaslat.Location = new System.Drawing.Point(29, 210);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(70, 61);
            this.btnbaslat.TabIndex = 4;
            this.btnbaslat.Text = "başlat";
            this.btnbaslat.UseVisualStyleBackColor = true;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // btndurdur
            // 
            this.btndurdur.Location = new System.Drawing.Point(122, 210);
            this.btndurdur.Name = "btndurdur";
            this.btndurdur.Size = new System.Drawing.Size(69, 61);
            this.btndurdur.TabIndex = 5;
            this.btndurdur.Text = "durdur";
            this.btndurdur.UseVisualStyleBackColor = true;
            this.btndurdur.Click += new System.EventHandler(this.btndurdur_Click);
            // 
            // sayma
            // 
            this.sayma.AutoSize = true;
            this.sayma.Location = new System.Drawing.Point(140, 116);
            this.sayma.Name = "sayma";
            this.sayma.Size = new System.Drawing.Size(18, 17);
            this.sayma.TabIndex = 6;
            this.sayma.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "sayarak yaz";
            // 
            // btndevam
            // 
            this.btndevam.Location = new System.Drawing.Point(212, 210);
            this.btndevam.Name = "btndevam";
            this.btndevam.Size = new System.Drawing.Size(66, 61);
            this.btndevam.TabIndex = 9;
            this.btndevam.Text = "devam et";
            this.btndevam.UseVisualStyleBackColor = true;
            this.btndevam.Click += new System.EventHandler(this.btndevam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 315);
            this.Controls.Add(this.btndevam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sayma);
            this.Controls.Add(this.btndurdur);
            this.Controls.Add(this.btnbaslat);
            this.Controls.Add(this.zaman);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SALİH";
            ((System.ComponentModel.ISupportInitialize)(this.zaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox metin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.NumericUpDown zaman;
        private System.Windows.Forms.Button btnbaslat;
        private System.Windows.Forms.Button btndurdur;
        private System.Windows.Forms.CheckBox sayma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndevam;
    }
}

