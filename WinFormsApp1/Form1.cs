using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Dice pelaaja1 = new Dice();
        Dice pelaaja2 = new Dice();
        //int pelaaja1piste = 0;
        //int pelaaja2piste = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkWinner()
        {
             if (pelaaja1.value> pelaaja2.value)
              {
                  labelVoittaja.Text = "Pelaaja 1 voitti";
              }
              if (pelaaja2.value > pelaaja1.value)
              {
                  labelVoittaja.Text = "Pelaaja 2 voitti";
              }
              if (pelaaja1.value == pelaaja2.value)
              {
                labelVoittaja.Text = "tasapeli";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pelaaja1.roll(); // 1
            // pelaaja1.Value

            button1.Enabled = false;
            //Random rnd = new Random(); // 2
            //pelaaja1piste = rnd.Next(1, 7); // 2
            //pelaaja1.value = pelaaja1piste; // 1

            labelPelaaja1.Text = pelaaja1.value.ToString();

            if (button2.Enabled == false)
            {
              checkWinner();

             }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pelaaja2.roll();
           
            
            button2.Enabled = false;
            //Random rnd = new Random();
            //pelaaja2piste = rnd.Next(1, 7);
            //pelaaja2.value = pelaaja2piste;

            labelPelaaja2.Text = pelaaja2.value.ToString();

            if (button1.Enabled == false)
            {
                checkWinner();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            labelPelaaja1.Text = "";
            labelPelaaja2.Text = "";
            labelVoittaja.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
