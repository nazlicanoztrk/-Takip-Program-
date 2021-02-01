using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace istakipProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if(girisKontrol(txt_kul.Text, txt_sifre.Text))
            {
                frm_main fm = new frm_main();
                this.Hide();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya parola hatalı!", "Giriş Başarız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            frm_kayit fk = new frm_kayit();
            fk.ShowDialog();
        }


        public bool girisKontrol(string kullaniciAdi, string parola)
        {
            bool onay = false;
            VTBaglan vt = new VTBaglan();
            Sifreleme sf = new Sifreleme();
            SqlCommand c = new SqlCommand("select * from tb_kullanicilar where kullaniciAdi=@p1 and parola=@p2", vt.bagla());
            c.Parameters.AddWithValue("@p1", kullaniciAdi);
            c.Parameters.AddWithValue("@p2", sf.RijndaelSifrele(parola));
            SqlDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                onay = true;
                giris(Convert.ToInt16(dr["ID"]), dr["adi"].ToString(), dr["soyadi"].ToString(), dr["kullaniciAdi"].ToString());
            }
            vt.bagla().Close();
            return onay;
        }



        private void giris(int _id, string _adi, string _soyadi, string _kullanici)
        {
            if (Kullanici._login == null)
                Kullanici._login = new Kullanici();

            Kullanici._login.Id = _id;
            Kullanici._login.Adi = _adi;
            Kullanici._login.Soyadi = _soyadi;
            Kullanici._login.KullaniciAdi = _kullanici;
        }

        private void bt_giris_Click(object sender, EventArgs e)
        {

            if (girisKontrol(txt_kul.Text, txt_sifre.Text))
            {
                frm_main fm = new frm_main();
                this.Hide();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya parola hatalı!", "Giriş Başarız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_kayiit_Click(object sender, EventArgs e)
        {
            frm_kayit fk = new frm_kayit();
            fk.ShowDialog();
        }
    }
}
