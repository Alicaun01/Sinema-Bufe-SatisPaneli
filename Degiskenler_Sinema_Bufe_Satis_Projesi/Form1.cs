using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değişkenler_Sinema_Bufe_Satis_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, cay, su, toplam;
            misir = Convert.ToInt16(txtbMisir.Text);
            bilet = Convert.ToInt16(txtbBilet.Text);
            cay = Convert.ToInt16(txtbCay.Text);
            su = Convert.ToInt16(txtbSu.Text);

            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            lblToplam.Text = toplam.ToString() + "TL";

            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + "TL";

         }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbBilet.Text = "";
            txtbCay.Text = "";
            txtbMisir.Text = "";
            txtbSu.Text = "";
            txtbMisir.Focus();
        }
    }
}
