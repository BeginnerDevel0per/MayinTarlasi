using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MayinTarlasi.Model;

namespace MayinTarlasi
{
    public class veritabani
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        List<puantablosu> puantablosus;

        public veritabani()
        {
            string dosyaYolu = Path.Combine(Application.StartupPath, "Puanlar.mdb");
            con = new OleDbConnection($"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dosyaYolu}");
        }

        public List<puantablosu> listele()
        {
            puantablosus = new List<puantablosu>();
            con.Open();
            da = new OleDbDataAdapter("Select * from puan_tablosu", con);
            ds = new DataSet();
            da.Fill(ds, "puan_tablosu");
            DataTable dt = ds.Tables["puan_tablosu"];
            foreach (DataRow row in dt.Rows)
            {
                puantablosu puantablo = new puantablosu();

                puantablo.ad = row["Ad"].ToString();
                puantablo.puan = Convert.ToInt32(row["Puan"]);
                puantablo.tarih = Convert.ToString(row["Tarih"]);


                puantablosus.Add(puantablo);
            }
            con.Close();
            return puantablosus;
        }

        public void ekle(puantablosu puantablo)
        {
            con.Open();
            cmd = new OleDbCommand(("INSERT INTO puan_tablosu (Ad, Puan, Tarih) VALUES (@ad, @puan, @tarih)"), con);
            cmd.Parameters.AddWithValue("@ad", puantablo.ad);
            cmd.Parameters.AddWithValue("@puan", puantablo.puan);
            cmd.Parameters.AddWithValue("@tarih", puantablo.tarih);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
