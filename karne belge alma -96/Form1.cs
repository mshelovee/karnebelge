using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karne_belge_alma__96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama, devamsizlik;
            int zayif;

            ortalama = Convert.ToDouble(txtOrtalama.Text);
            devamsizlik = Convert.ToDouble(txtDevamsizlik.Text);
            zayif = Convert.ToInt32(txtZayif.Text);

            if (ortalama >= 70 && ortalama > 85 && devamsizlik < 5 && zayif == 0)
            {
                lblDurum.Text = "Teşekkür Belesi Alınız.";
            }

            else if (ortalama >= 85 && ortalama > 100 && devamsizlik < 5 && zayif == 0)
            {
                lblDurum.Text = "Taktir Belgesi Aldınız";
            }
             else if (zayif >= 1)
            {
                lblDurum.Text = "Zayıf var.";
            }
            else if (devamsizlik >= 10)
            {
                lblDurum.Text = "Devamsızlık Fazla";
            }
            else
            {
                lblDurum.Text = "BELGE YOK.";
            }

            
            
            // &&= C+ kodlama dilinde "VE" kelimesini ifade eder.
        }  
        
         
    }
}
