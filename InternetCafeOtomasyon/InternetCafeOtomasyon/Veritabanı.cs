using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeOtomasyon
{
    public class Veritabanı
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InternetCafeOtomasyon;Integrated Security=True;Trust Server Certificate=False;");
        public static DataTable SepetListele(DataGridView gridwiew)
        {





            SqlDataAdapter adtrMasalar = new SqlDataAdapter("SELECT  * FROM TBLSEPET", baglanti);
            DataTable tblMasalar = new DataTable();
            adtrMasalar.Fill(tblMasalar);

            gridwiew.DataSource = tblMasalar;

            return tblMasalar;




        }
        public static DataTable ComboyaBosMasaGetir(ComboBox combo)
        {


            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT MasaID, Masalar FROM dbo.TBLMasalar WHERE durumu = 'BOS'", baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.DisplayMember = "Masalar";
            combo.ValueMember = "MasaID";
            baglanti.Close();
            return tbl;
        }
        public static void ESG(SqlCommand command, string sorgu)
        {
            baglanti.Open();
            command.Connection = baglanti;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            baglanti.Close();
        }
        public static SqlDataReader ListviewdeKayitlariGoster(ListView list)
        {
            baglanti.Open();
            SqlCommand CMD = new SqlCommand("SELECT * FROM TBLHareketler", baglanti);
            SqlDataReader dr = CMD.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                ekle.SubItems.Add(dr[3].ToString());
                ekle.SubItems.Add(dr[4].ToString());
                ekle.SubItems.Add(dr[5].ToString());
                ekle.SubItems.Add(dr[6].ToString());
                list.Items.Add(ekle);
            }
            baglanti.Close();
            return dr;
        }
    }
}
