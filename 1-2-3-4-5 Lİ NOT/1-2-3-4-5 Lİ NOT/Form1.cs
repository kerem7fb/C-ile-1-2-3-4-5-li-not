﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2_3_4_5_Lİ_NOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if (sayi < 0) 
            {
                MessageBox.Show("0 dan Büyük Sayı Giriniz");
            }
            else if (sayi < 25) 
            {
                MessageBox.Show("Notunuz 0");
            }
            else if (sayi < 45)
            {
                MessageBox.Show("Notunuz 1");
            }
            else if (sayi < 55)
            {
                MessageBox.Show("Notunuz 2");
            }
            else if (sayi < 70)
            {
                MessageBox.Show("Notunuz 3");
            }
            else if (sayi < 85)
            {
                MessageBox.Show("Notunuz 4");
            }
            else if (sayi <= 100)
            {
                MessageBox.Show("Notunuz 5");
            }
            else 
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
        }
    }
}
