using MayinTarlasi.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            

            InitializeComponent();
        }
         veritabani veritabani=new veritabani();
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            rdr_kolay.Checked = true;
        }

        ArrayList mayinlar = new ArrayList();
        int puan;
        private void btn_oyunubaslat_Click(object sender, EventArgs e)
        {
            int olusturulacakmayin;
            if (rdr_kolay.Checked)
            {
                olusturulacakmayin = 10;

            }
            else if (rdr_orta.Checked)
            {
                olusturulacakmayin = 25;
            }
            else
            {
                olusturulacakmayin = 40;
            }

            if (rdr_kolay.Checked == false || rdr_orta.Checked == false || rdr_zor.Checked == false)
            {
                if (!string.IsNullOrEmpty(txt_oyuncuadi.Text))
                {
                    bool adkontrol=false;
                    if (dataGridView1.Rows.Count>0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (txt_oyuncuadi.Text==dataGridView1.Rows[i].Cells["Ad"].Value.ToString().ToLower())
                            {
                                adkontrol=true;
                                break;
                               
                            }
                            else
                            {
                                adkontrol = false;
                            }
                        }
                    }
                    if (adkontrol==false)
                    {
                        int olusturulacaktarla = 100;
                        Random random = new Random();
                        int sayi = 0;
                        temizle();
                        mayinlar.Clear();// Önceki mayın bilgilerini temizledim
                        for (int i = 0; i < olusturulacakmayin; i++)
                        {

                            sayi = random.Next(0, olusturulacaktarla);
                            //eğer listemin içinde -1 varsa ekleme
                            if (mayinlar.Contains(sayi) != true)
                            {
                                mayinlar.Add(sayi);
                                sayi = 0;
                            }
                            else
                            {
                                i--; // Aynı sayıyı tekrar ekleme
                            }

                        }
                        for (int i = 0; i < olusturulacaktarla; i++)
                        {
                            //burada bütün tarlaları button biçiminde oluşturduk
                            Button button = new Button();
                            button.Dock = DockStyle.Fill;
                            button.BackColor = Color.Blue;
                            if (mayinlar.Contains(i))
                            {
                                button.Tag = -1;

                            }
                            else
                            {
                                if (rdr_kolay.Checked)
                                {
                                    button.Tag = 1;

                                }
                                else if (rdr_orta.Checked)
                                {
                                    button.Tag = 3;
                                }
                                else
                                {
                                    button.Tag = 5;
                                }
                                
                            }
                            button.Click += Button_Click;
                            tableLayoutPanel1.Controls.Add(button);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kayıtlı");
                    }


                }
                else
                {
                    MessageBox.Show("Kullanıcı adı girmedin.");
                }
    
            }
            else
            {
                MessageBox.Show("Zorluk seviyesi seçmedin.");

            }

        }



        private void Button_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            tiklanan.Text = tiklanan.Tag.ToString();

            //mayın denk gelinirse eğer alt kısım çalışır
            if (Convert.ToInt32(tiklanan.Tag) == -1)
            {
                tiklanan.Text = "";
                tiklanan.BackgroundImage = Image.FromFile("mayinresim.png");
                tiklanan.BackgroundImageLayout = ImageLayout.Stretch;

                //aşşağıda oyuncu yandığı zaman bütün buttonları açacak
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                {
                    if (Convert.ToInt32(tableLayoutPanel1.Controls[i].Tag) == -1)
                    {
                        tableLayoutPanel1.Controls[i].BackgroundImage = Image.FromFile("mayinresim.png");
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        tableLayoutPanel1.Controls[i].Text = tableLayoutPanel1.Controls[i].Tag.ToString();
                    }
                }
                puantablosu puantablo = new puantablosu();
                puantablo.ad = txt_oyuncuadi.Text;
                puantablo.puan =Convert.ToInt32(txt_puan.Text);
                puantablo.tarih =Convert.ToString(DateTime.Now);
                veritabani.ekle(puantablo);
                MessageBox.Show("Mayına bastın :)");
                temizle();
                listele();
            }

            //burasıda mayına denk gelmediği sürece çalısacak
            else
            {
                tiklanan.BackColor = Color.Green;
                puan = puan + Convert.ToInt32(tiklanan.Tag);
                txt_puan.Text = puan.ToString();

            }
        }


        private void temizle()
        {
            for (int i = tableLayoutPanel1.Controls.Count - 1; i >= 0; i--)
            {
                Control control = tableLayoutPanel1.Controls[i];
                tableLayoutPanel1.Controls.Remove(control);
                control.Dispose(); // Kontrolü bellekten de temizledim
            }

            txt_puan.Text = "00";

        }

        private void listele()
        {
            dataGridView1.DataSource = veritabani.listele();
        }

        private void rdr_kolay_CheckedChanged(object sender, EventArgs e)
        {
            txt_mayinsayisi.Text = "10";
        }


        private void rdr_orta_CheckedChanged(object sender, EventArgs e)
        {
            txt_mayinsayisi.Text = "25";
        }

        private void rdr_zor_CheckedChanged(object sender, EventArgs e)
        {
            txt_mayinsayisi.Text = "40";
        }


    }
}
