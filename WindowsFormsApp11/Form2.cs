using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        public Form2(string text,string Name,string Tactic)
        {
            InitializeComponent();
            pictureBox1.Load($"https://countryflags.io/{text}/shiny/64.png");
            label1.Font = new Font("Calibri", 24);
            label1.Text = Name;
            pictureBox2.Load("b.png");
            pictureBox4.Load("o.jpg");
            pictureBox5.Load("o.jpg");
            pictureBox6.Load("o.jpg");
            pictureBox3.Load("o.jpg");




            pictureBox7.Load("o.jpg");
            pictureBox8.Load("o.jpg");
            pictureBox9.Load("o.jpg");
            pictureBox10.Load("o.jpg");
            pictureBox11.Load("o.jpg");

            pictureBox12.Load("o.jpg");
            pictureBox13.Load("o.jpg");
            pictureBox14.Load("o.jpg");




        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
