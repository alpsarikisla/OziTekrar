using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriErisimKatmani;

namespace OziTekrar
{
    public partial class PersonelKayitForm : Form
    {
        VeritabaniMetotlari vm = new VeritabaniMetotlari();

        public PersonelKayitForm()
        {
            InitializeComponent();
        }

        private void PersonelKayitForm_Load(object sender, EventArgs e)
        {
            cmb_sehir.DataSource = vm.SehirleriGetir();
            cmb_sehir.DisplayMember = "Isim";
            cmb_sehir.ValueMember = "ID";
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            cmb_sehir.DataSource = vm.SehirleriGetir();
            cmb_sehir.DisplayMember = "Isim";
            cmb_sehir.ValueMember = "ID";
        }

        private void bt_ekle_Click(object sender, EventArgs e)
        {
            string isim = tb_isim.Text;
            string soyisim = tb_soyisim.Text;
            string telefon = mtb_telefon.Text;
            string adres = tb_adres.Text;
            int sehirid = Convert.ToInt32(cmb_sehir.SelectedValue);

            if (vm.PersonelEkle(isim, soyisim, telefon, adres, sehirid))
            {
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
