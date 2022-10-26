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
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            string isim = tb_isim.Text;
            string soyad = tb_soyad.Text;
            int dogumyili = Convert.ToInt32(tb_dogumyili.Text);
            int yas = 2022 - dogumyili;


            lbl_sonuc.Text = isim + " " + soyad + " " + yas;
        }
    }
}
