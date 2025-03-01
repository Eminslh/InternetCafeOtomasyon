using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace InternetCafeOtomasyon
{
    public partial class Form1 : Form
    {

        

        private BindingSource bbindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();  // Yeni BindingSource nesnesi

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Button btn;
        private void SecileneGore(object sender, MouseEventArgs e)
        {
            btn = sender as Button;
            if (btn.BackColor == Color.Red) 
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
            }
            if (btn.BackColor == Color.Green)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
            }

        }
        RadioButton rb;
        private void RadioButtonSeciliyeGore(object sender, EventArgs e)
        {
            rb = sender as RadioButton;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonSuresiz.Checked = true;
            Yenile();
            cmbBosMasalar.Text = "";

        }

        private void Yenile()
        {
            Veritabanı.SepetListele(dataGridView1);
            Veritabanı.ListviewdeKayitlariGoster(listView1);
            Veritabanı.ComboyaBosMasaGetir(cmbBosMasalar);

            foreach (Control item in Controls)
            {
                if (item is Button)
                {

                    if (item.Name != btnMasaAc.Name)
                    {
                        Veritabanı.baglanti.Open();
                        SqlCommand komut = new SqlCommand("select * from TBLMasalar", Veritabanı.baglanti);
                        SqlDataReader dr = komut.ExecuteReader();

                        while (dr.Read())
                        {

                            if (dr["durumu"].ToString() == "BOS" && dr["Masalar"].ToString() == item.Text)
                            {
                                item.BackColor = System.Drawing.Color.Green;
                            }
                            else if (dr["durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == item.Text)
                            {
                                item.BackColor = System.Drawing.Color.Red;

                            }



                        }
                        Veritabanı.baglanti.Close();
                    }
                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSaatUcreti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

