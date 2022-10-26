using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OziTekrar
{
    public partial class FirmaKayitFormu : Form
    {
        public FirmaKayitFormu()
        {
            InitializeComponent();
            //string[] sehirler = new string[] { "Adana", "Adıyaman", "Eskişehir" };

            //List<string> sehirler = new List<string>();
            //sehirler.Add("Ankara");
            //sehirler.Add("Adıyaman");
            //sehirler.Add("Eskişehir");

            List<Sehir> sehirler = new List<Sehir>();
            sehirler.Add(new Sehir() { ID = 6, Isim = "Ankara" });
            sehirler.Add(new Sehir() { ID = 26, Isim = "Eskişehir" });
            sehirler.Add(new Sehir() { ID = 35, Isim = "İzmir" });

            cb_sehir.DataSource = sehirler;
            cb_sehir.DisplayMember = "Isim";
            cb_sehir.ValueMember = "ID";

        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            string firmaadi = tb_firmaAdi.Text;
            string firmaunvan = tb_firmaUnvan.Text;
            string telefon = tb_firmaTelefon.Text;
            string adres = tb_firmaAdres.Text;
            string sehir = cb_sehir.Text;
            string sehirID = cb_sehir.SelectedValue.ToString();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Firma Adı = " + firmaadi);
            sb.AppendLine("Firma Unvan = " + firmaunvan);
            sb.AppendLine("Firma Telefon = " + telefon);
            sb.AppendLine("Firma Adres = " + adres);
            sb.AppendLine("Firma Şehir = " + sehir + "(" + sehirID + ")");
            tb_sonuc.Text = sb.ToString();

        }

        
    }
}
