using DATA.İslemSınıfları;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Toplama toplama = new Toplama();
            lblSonuc.Text = toplama.Topla(Convert.ToDouble(txtSayi1.Text), Convert.ToDouble(txtSayi2.Text)).ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            Cikarma cikarma = new Cikarma();
            lblSonuc.Text = cikarma.Cikar(Convert.ToDouble(txtSayi1.Text), Convert.ToDouble(txtSayi2.Text)).ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            Carpma carpma = new Carpma();
            lblSonuc.Text = carpma.Carp(Convert.ToDouble(txtSayi1.Text), Convert.ToDouble(txtSayi2.Text)).ToString();

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            Bolme bolme = new Bolme();
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);


            Metotlar.SifiraBolme(sayi2);


            lblSonuc.Text = bolme.Bol(sayi1, sayi2).ToString();
        }

        private void txtSayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
