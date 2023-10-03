using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bölüm2uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKarlıstırma_Click(object sender, EventArgs e)
        {
            int sayı1, say2;
            sayı1 =Convert.ToInt32(txtsayı1.Text);
            say2 =Convert.ToInt32(txtsayı2.Text);
            if (sayı1 > say2)
            {
                MessageBox.Show("1.sayıdan  büyüktür");

            }
            if ( sayı1 == say2)
            {
                MessageBox.Show("sayılar birbirne eşitir");
            }
            if (sayı1 < say2)
            {
                MessageBox.Show("2SAYI 1SAYIDAN BÜYÜKTÜR");
            }
        }
    }
}
