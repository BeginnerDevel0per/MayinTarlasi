namespace MayinTarlasi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_mayinsayisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdr_kolay = new System.Windows.Forms.RadioButton();
            this.rdr_orta = new System.Windows.Forms.RadioButton();
            this.txt_puan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_oyunubaslat = new System.Windows.Forms.Button();
            this.txt_oyuncuadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdr_zor = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mayinsayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1520, 553);
            this.splitContainer1.SplitterDistance = 722;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 553);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 271);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puan Tablosu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_mayinsayisi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdr_kolay);
            this.groupBox2.Controls.Add(this.rdr_orta);
            this.groupBox2.Controls.Add(this.txt_puan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_oyunubaslat);
            this.groupBox2.Controls.Add(this.txt_oyuncuadi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdr_zor);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ayarlar";
            // 
            // txt_mayinsayisi
            // 
            this.txt_mayinsayisi.AutoSize = true;
            this.txt_mayinsayisi.Location = new System.Drawing.Point(156, 220);
            this.txt_mayinsayisi.Name = "txt_mayinsayisi";
            this.txt_mayinsayisi.Size = new System.Drawing.Size(21, 16);
            this.txt_mayinsayisi.TabIndex = 14;
            this.txt_mayinsayisi.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mayın Sayısı:";
            // 
            // rdr_kolay
            // 
            this.rdr_kolay.AutoSize = true;
            this.rdr_kolay.Location = new System.Drawing.Point(19, 32);
            this.rdr_kolay.Name = "rdr_kolay";
            this.rdr_kolay.Size = new System.Drawing.Size(62, 20);
            this.rdr_kolay.TabIndex = 12;
            this.rdr_kolay.TabStop = true;
            this.rdr_kolay.Text = "Kolay";
            this.rdr_kolay.UseVisualStyleBackColor = true;
            this.rdr_kolay.CheckedChanged += new System.EventHandler(this.rdr_kolay_CheckedChanged);
            // 
            // rdr_orta
            // 
            this.rdr_orta.AutoSize = true;
            this.rdr_orta.Location = new System.Drawing.Point(19, 58);
            this.rdr_orta.Name = "rdr_orta";
            this.rdr_orta.Size = new System.Drawing.Size(53, 20);
            this.rdr_orta.TabIndex = 11;
            this.rdr_orta.TabStop = true;
            this.rdr_orta.Text = "Orta";
            this.rdr_orta.UseVisualStyleBackColor = true;
            this.rdr_orta.CheckedChanged += new System.EventHandler(this.rdr_orta_CheckedChanged);
            // 
            // txt_puan
            // 
            this.txt_puan.AutoSize = true;
            this.txt_puan.Location = new System.Drawing.Point(453, 220);
            this.txt_puan.Name = "txt_puan";
            this.txt_puan.Size = new System.Drawing.Size(21, 16);
            this.txt_puan.TabIndex = 10;
            this.txt_puan.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Puan:";
            // 
            // btn_oyunubaslat
            // 
            this.btn_oyunubaslat.Location = new System.Drawing.Point(159, 134);
            this.btn_oyunubaslat.Name = "btn_oyunubaslat";
            this.btn_oyunubaslat.Size = new System.Drawing.Size(315, 49);
            this.btn_oyunubaslat.TabIndex = 8;
            this.btn_oyunubaslat.Text = "Oyunu Başlat";
            this.btn_oyunubaslat.UseVisualStyleBackColor = true;
            this.btn_oyunubaslat.Click += new System.EventHandler(this.btn_oyunubaslat_Click);
            // 
            // txt_oyuncuadi
            // 
            this.txt_oyuncuadi.Location = new System.Drawing.Point(313, 46);
            this.txt_oyuncuadi.Name = "txt_oyuncuadi";
            this.txt_oyuncuadi.Size = new System.Drawing.Size(161, 22);
            this.txt_oyuncuadi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Oyuncu Adı:";
            // 
            // rdr_zor
            // 
            this.rdr_zor.AutoSize = true;
            this.rdr_zor.Location = new System.Drawing.Point(19, 85);
            this.rdr_zor.Name = "rdr_zor";
            this.rdr_zor.Size = new System.Drawing.Size(48, 20);
            this.rdr_zor.TabIndex = 5;
            this.rdr_zor.TabStop = true;
            this.rdr_zor.Text = "Zor";
            this.rdr_zor.UseVisualStyleBackColor = true;
            this.rdr_zor.CheckedChanged += new System.EventHandler(this.rdr_zor_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mayın Sayısı:";
            // 
            // txt_mayinsayisi
            // 
            this.txt_mayinsayisi.AutoSize = true;
            this.txt_mayinsayisi.Location = new System.Drawing.Point(156, 220);
            this.txt_mayinsayisi.Name = "txt_mayinsayisi";
            this.txt_mayinsayisi.Size = new System.Drawing.Size(21, 16);
            this.txt_mayinsayisi.TabIndex = 14;
            this.txt_mayinsayisi.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1520, 553);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1538, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdr_zor;
        private System.Windows.Forms.Label txt_puan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_oyunubaslat;
        private System.Windows.Forms.TextBox txt_oyuncuadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdr_orta;
        private System.Windows.Forms.RadioButton rdr_kolay;
        private System.Windows.Forms.Label txt_mayinsayisi;
        private System.Windows.Forms.Label label3;
    }
}

