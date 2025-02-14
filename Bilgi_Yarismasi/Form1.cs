﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            button5.Enabled = true;
            label5.Text = btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            button5.Enabled = true;
            label5.Text=btnb.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text=yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            button5.Enabled = true;
            label5.Text = btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled= false;
            btnb.Enabled= false;
            btnc.Enabled= false;
            btnd.Enabled= false;
            button5.Enabled = true;
            
            label5.Text = btna.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled= true;
            btnd.Enabled= true;
            button5.Enabled= false;

            pictureBox1.Visible = false;
            pictureBox2.Visible= false;
            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label4.Text = "1923";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi şehir Ege Bölgemizde bulunmaz?";
                btna.Text = "İzmir";
                btnb.Text = "Balıkesir";
                btnc.Text = "Aydın";
                btnd.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if(soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                btna.Text = "Sait Faik";
                btnb.Text = "Cemal Süreyya";
                btnc.Text = "Attila İlhan";
                btnd.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                button5.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }

        }
    }
}
