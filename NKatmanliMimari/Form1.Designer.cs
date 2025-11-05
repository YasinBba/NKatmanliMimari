namespace NKatmanliMimari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtGorev = new System.Windows.Forms.TextBox();
            this.TxtSehir = new System.Windows.Forms.TextBox();
            this.TxtMaas = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(98, 41);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(121, 27);
            this.TxtId.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Görev:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şehir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Maaş:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(98, 74);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(121, 27);
            this.TxtAd.TabIndex = 9;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(98, 107);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(121, 27);
            this.TxtSoyad.TabIndex = 10;
            // 
            // TxtGorev
            // 
            this.TxtGorev.Location = new System.Drawing.Point(317, 41);
            this.TxtGorev.Name = "TxtGorev";
            this.TxtGorev.Size = new System.Drawing.Size(121, 27);
            this.TxtGorev.TabIndex = 11;
            // 
            // TxtSehir
            // 
            this.TxtSehir.Location = new System.Drawing.Point(317, 74);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(121, 27);
            this.TxtSehir.TabIndex = 12;
            // 
            // TxtMaas
            // 
            this.TxtMaas.Location = new System.Drawing.Point(317, 107);
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.Size = new System.Drawing.Size(121, 27);
            this.TxtMaas.TabIndex = 13;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(460, 89);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(119, 45);
            this.BtnEkle.TabIndex = 14;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(585, 41);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(119, 45);
            this.BtnSil.TabIndex = 15;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(585, 89);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(119, 45);
            this.BtnGuncelle.TabIndex = 16;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(722, 439);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtMaas);
            this.Controls.Add(this.TxtSehir);
            this.Controls.Add(this.TxtGorev);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtGorev;
        private System.Windows.Forms.TextBox TxtSehir;
        private System.Windows.Forms.TextBox TxtMaas;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}

