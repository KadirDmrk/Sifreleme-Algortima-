﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Şifreleme_Algoritmaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string anametin = textBox2.Text;
            byte[] veridizm = ASCIIEncoding.ASCII.GetBytes(anametin); // Her karakteri bilgisayardaki karşılığını alıyor. 
            string sifrelimetin = Convert.ToBase64String(veridizm);
            textBox1.Text = sifrelimetin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metincoz=textBox1.Text;
            byte[] veridizimcozulen = Convert.FromBase64String(metincoz);
            string anametin2=ASCIIEncoding.ASCII.GetString(veridizimcozulen);
            textBox2.Text = anametin2;
        }
    }
}
