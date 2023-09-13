namespace pelabuhan
{
    partial class pelabuhan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txNegara = new System.Windows.Forms.TextBox();
            this.txPelabuhan = new System.Windows.Forms.TextBox();
            this.txKodeBarang = new System.Windows.Forms.TextBox();
            this.txBarang = new System.Windows.Forms.TextBox();
            this.txHarga = new System.Windows.Forms.TextBox();
            this.txTarifBeaMasuk = new System.Windows.Forms.TextBox();
            this.txTotalHarga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Negara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pelabuhan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = " Tarif Bea Masuk";
            // 
            // txNegara
            // 
            this.txNegara.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txNegara.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txNegara.Location = new System.Drawing.Point(219, 40);
            this.txNegara.Name = "txNegara";
            this.txNegara.Size = new System.Drawing.Size(157, 20);
            this.txNegara.TabIndex = 5;
            this.txNegara.TextChanged += new System.EventHandler(this.txNegara_TextChanged);
            // 
            // txPelabuhan
            // 
            this.txPelabuhan.Location = new System.Drawing.Point(219, 77);
            this.txPelabuhan.Name = "txPelabuhan";
            this.txPelabuhan.Size = new System.Drawing.Size(157, 20);
            this.txPelabuhan.TabIndex = 6;
            this.txPelabuhan.TextChanged += new System.EventHandler(this.txPelabuhan_TextChanged);
            // 
            // txKodeBarang
            // 
            this.txKodeBarang.Location = new System.Drawing.Point(219, 119);
            this.txKodeBarang.Name = "txKodeBarang";
            this.txKodeBarang.Size = new System.Drawing.Size(157, 20);
            this.txKodeBarang.TabIndex = 7;
            this.txKodeBarang.TextChanged += new System.EventHandler(this.txKodeBarang_TextChanged);
            // 
            // txBarang
            // 
            this.txBarang.Location = new System.Drawing.Point(219, 160);
            this.txBarang.Multiline = true;
            this.txBarang.Name = "txBarang";
            this.txBarang.Size = new System.Drawing.Size(157, 76);
            this.txBarang.TabIndex = 8;
            // 
            // txHarga
            // 
            this.txHarga.Location = new System.Drawing.Point(219, 267);
            this.txHarga.Name = "txHarga";
            this.txHarga.Size = new System.Drawing.Size(157, 20);
            this.txHarga.TabIndex = 9;
            this.txHarga.TextChanged += new System.EventHandler(this.txHarga_TextChanged);
            // 
            // txTarifBeaMasuk
            // 
            this.txTarifBeaMasuk.Location = new System.Drawing.Point(219, 310);
            this.txTarifBeaMasuk.Name = "txTarifBeaMasuk";
            this.txTarifBeaMasuk.ReadOnly = true;
            this.txTarifBeaMasuk.Size = new System.Drawing.Size(87, 20);
            this.txTarifBeaMasuk.TabIndex = 10;
            // 
            // txTotalHarga
            // 
            this.txTotalHarga.Location = new System.Drawing.Point(219, 350);
            this.txTotalHarga.Name = "txTotalHarga";
            this.txTotalHarga.ReadOnly = true;
            this.txTotalHarga.Size = new System.Drawing.Size(157, 20);
            this.txTotalHarga.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "%";
            // 
            // pelabuhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 415);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txTotalHarga);
            this.Controls.Add(this.txTarifBeaMasuk);
            this.Controls.Add(this.txHarga);
            this.Controls.Add(this.txBarang);
            this.Controls.Add(this.txKodeBarang);
            this.Controls.Add(this.txPelabuhan);
            this.Controls.Add(this.txNegara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "pelabuhan";
            this.Text = "form pelabuhan";
            this.Load += new System.EventHandler(this.pelabuhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txNegara;
        private System.Windows.Forms.TextBox txPelabuhan;
        private System.Windows.Forms.TextBox txKodeBarang;
        private System.Windows.Forms.TextBox txBarang;
        private System.Windows.Forms.TextBox txHarga;
        private System.Windows.Forms.TextBox txTarifBeaMasuk;
        private System.Windows.Forms.TextBox txTotalHarga;
        private System.Windows.Forms.Label label6;
    }
}

