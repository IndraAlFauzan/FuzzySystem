
namespace FuzzySystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.Permintaan = new System.Windows.Forms.Label();
            this.tbPermintaan = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHasil = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPemintaanBanyak = new System.Windows.Forms.TextBox();
            this.tbPermintaanSedikit = new System.Windows.Forms.TextBox();
            this.tbStokBanyak = new System.Windows.Forms.TextBox();
            this.tbStokSedikit = new System.Windows.Forms.TextBox();
            this.btHitung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbPermintaan = new System.Windows.Forms.Label();
            this.lbSS = new System.Windows.Forms.Label();
            this.lbSB = new System.Windows.Forms.Label();
            this.lbPS = new System.Windows.Forms.Label();
            this.lbPB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUZZY SISTEM";
            // 
            // Permintaan
            // 
            this.Permintaan.AutoSize = true;
            this.Permintaan.Location = new System.Drawing.Point(285, 178);
            this.Permintaan.Name = "Permintaan";
            this.Permintaan.Size = new System.Drawing.Size(80, 17);
            this.Permintaan.TabIndex = 1;
            this.Permintaan.Text = "Permintaan";
            // 
            // tbPermintaan
            // 
            this.tbPermintaan.Location = new System.Drawing.Point(288, 207);
            this.tbPermintaan.Name = "tbPermintaan";
            this.tbPermintaan.Size = new System.Drawing.Size(170, 22);
            this.tbPermintaan.TabIndex = 2;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(526, 207);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(100, 22);
            this.tbStock.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jumlah Produksi Ideal Adalah :";
            // 
            // lbHasil
            // 
            this.lbHasil.AutoSize = true;
            this.lbHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHasil.Location = new System.Drawing.Point(812, 290);
            this.lbHasil.Name = "lbHasil";
            this.lbHasil.Size = new System.Drawing.Size(27, 39);
            this.lbHasil.TabIndex = 6;
            this.lbHasil.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Permintaan Paling Banyak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Permintaan Paling Sedikit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(722, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stok Paling Sedikit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Stok Paling Banyak";
            // 
            // tbPemintaanBanyak
            // 
            this.tbPemintaanBanyak.Location = new System.Drawing.Point(82, 122);
            this.tbPemintaanBanyak.Name = "tbPemintaanBanyak";
            this.tbPemintaanBanyak.Size = new System.Drawing.Size(100, 22);
            this.tbPemintaanBanyak.TabIndex = 11;
            // 
            // tbPermintaanSedikit
            // 
            this.tbPermintaanSedikit.Location = new System.Drawing.Point(288, 121);
            this.tbPermintaanSedikit.Name = "tbPermintaanSedikit";
            this.tbPermintaanSedikit.Size = new System.Drawing.Size(100, 22);
            this.tbPermintaanSedikit.TabIndex = 12;
            // 
            // tbStokBanyak
            // 
            this.tbStokBanyak.Location = new System.Drawing.Point(536, 121);
            this.tbStokBanyak.Name = "tbStokBanyak";
            this.tbStokBanyak.Size = new System.Drawing.Size(100, 22);
            this.tbStokBanyak.TabIndex = 13;
            // 
            // tbStokSedikit
            // 
            this.tbStokSedikit.Location = new System.Drawing.Point(725, 121);
            this.tbStokSedikit.Name = "tbStokSedikit";
            this.tbStokSedikit.Size = new System.Drawing.Size(100, 22);
            this.tbStokSedikit.TabIndex = 14;
            // 
            // btHitung
            // 
            this.btHitung.Location = new System.Drawing.Point(665, 203);
            this.btHitung.Name = "btHitung";
            this.btHitung.Size = new System.Drawing.Size(75, 30);
            this.btHitung.TabIndex = 15;
            this.btHitung.Text = "Hitung";
            this.btHitung.UseVisualStyleBackColor = true;
            this.btHitung.Click += new System.EventHandler(this.btHitung_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stok Paling Sedikit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Stok Paling Banyak";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Permintaan Paling Sedikit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Permintaan Paling Banyak";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Stok Saat Ini";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(158, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Permintaan Saat ini";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(352, 441);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(0, 17);
            this.lbStock.TabIndex = 27;
            // 
            // lbPermintaan
            // 
            this.lbPermintaan.AutoSize = true;
            this.lbPermintaan.Location = new System.Drawing.Point(352, 407);
            this.lbPermintaan.Name = "lbPermintaan";
            this.lbPermintaan.Size = new System.Drawing.Size(0, 17);
            this.lbPermintaan.TabIndex = 26;
            // 
            // lbSS
            // 
            this.lbSS.AutoSize = true;
            this.lbSS.Location = new System.Drawing.Point(352, 378);
            this.lbSS.Name = "lbSS";
            this.lbSS.Size = new System.Drawing.Size(0, 17);
            this.lbSS.TabIndex = 25;
            // 
            // lbSB
            // 
            this.lbSB.AutoSize = true;
            this.lbSB.Location = new System.Drawing.Point(352, 344);
            this.lbSB.Name = "lbSB";
            this.lbSB.Size = new System.Drawing.Size(0, 17);
            this.lbSB.TabIndex = 24;
            // 
            // lbPS
            // 
            this.lbPS.AutoSize = true;
            this.lbPS.Location = new System.Drawing.Point(352, 311);
            this.lbPS.Name = "lbPS";
            this.lbPS.Size = new System.Drawing.Size(0, 17);
            this.lbPS.TabIndex = 23;
            // 
            // lbPB
            // 
            this.lbPB.AutoSize = true;
            this.lbPB.Location = new System.Drawing.Point(352, 270);
            this.lbPB.Name = "lbPB";
            this.lbPB.Size = new System.Drawing.Size(0, 17);
            this.lbPB.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 537);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbPermintaan);
            this.Controls.Add(this.lbSS);
            this.Controls.Add(this.lbSB);
            this.Controls.Add(this.lbPS);
            this.Controls.Add(this.lbPB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btHitung);
            this.Controls.Add(this.tbStokSedikit);
            this.Controls.Add(this.tbStokBanyak);
            this.Controls.Add(this.tbPermintaanSedikit);
            this.Controls.Add(this.tbPemintaanBanyak);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbPermintaan);
            this.Controls.Add(this.Permintaan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Permintaan;
        private System.Windows.Forms.TextBox tbPermintaan;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHasil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPemintaanBanyak;
        private System.Windows.Forms.TextBox tbPermintaanSedikit;
        private System.Windows.Forms.TextBox tbStokBanyak;
        private System.Windows.Forms.TextBox tbStokSedikit;
        private System.Windows.Forms.Button btHitung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbPermintaan;
        private System.Windows.Forms.Label lbSS;
        private System.Windows.Forms.Label lbSB;
        private System.Windows.Forms.Label lbPS;
        private System.Windows.Forms.Label lbPB;
    }
}

