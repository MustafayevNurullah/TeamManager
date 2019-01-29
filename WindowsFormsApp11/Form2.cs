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
        public Form2(string text,string Name,string Tactic,List<string> list)
        {
            InitializeComponent();
            pictureBox1.Load($"https://countryflags.io/{text}/shiny/64.png");
            label.Font = new Font("Calibri", 24);
            label.Text = Name;

            switch (Tactic)
            {
                case "4-4-2":
                   
                    label0.BackColor = Color.FromArgb(174,12,43);
                    label0.Text = list[0];
                    label1.Text = list[1];
                    label1.BackColor = Color.FromArgb(174,12,43);

                    label2.BackColor = Color.FromArgb(174, 12, 43);
                    label2.Text = list[2];
                    label3.Text = list[3];
                    label3.BackColor = Color.FromArgb(174, 12, 43);

                    label4.BackColor = Color.FromArgb(174, 12, 43);
                    label4.Text = list[4];
                    label5.Text = list[5];
                    label5.BackColor = Color.FromArgb(174, 12, 43);

                    label6.BackColor = Color.FromArgb(174, 12, 43);
                    label6.Text = list[6];
                    label7.Text = list[7];
                    label7.BackColor = Color.FromArgb(174, 12, 43);

                    label8.BackColor = Color.FromArgb(174, 12, 43);
                    label8.Text = list[8];
                    label9.Text = list[9];
                    label9.BackColor = Color.FromArgb(174, 12, 43);

                    label10.BackColor = Color.FromArgb(174, 12, 43);
                    label10.Text = list[10];
                    pictureBox2.Load("b.png");
                    pictureBox4.Load("o.png");
                    pictureBox5.Load("o.png");
                    pictureBox6.Load("o.png");
                    pictureBox3.Load("o.png");

                   
                    pictureBox7.Load("o.png");
                    pictureBox8.Load("o.png");
                    pictureBox9.Load("o.png");
                    pictureBox10.Load("o.png");
                    pictureBox11.Load("o.png");

                    pictureBox12.Load("o.png");
                    pictureBox13.Load("o.png");
                    pictureBox14.Load("o.png");


                    break;
                case "4-3-3":
                   
                    pictureBox9.Location = new Point(615, 37);
                    pictureBox6.Location = new Point(608, 200);
                    label6.Location = new Point(625, 215);
                    label7.Location = new Point(630,48);
                    pictureBox2.Load("b.png");
                    pictureBox4.Load("o.png");
                    pictureBox5.Load("o.png");
                    pictureBox6.Load("o.png");
                    pictureBox3.Load("o.png");
                    pictureBox7.Load("o.png");
                    pictureBox8.Load("o.png");
                    pictureBox9.Load("o.png");
                    pictureBox10.Load("o.png");
                    pictureBox11.Load("o.png");
                    pictureBox12.Load("o.png");
                    pictureBox13.Load("o.png");
                    pictureBox14.Load("o.png");
                    break;
                case "3-4-3":
                   
                    pictureBox11.Location = new Point(615, 37);  
                    pictureBox10.Location = new Point(608, 348);
                    pictureBox2.Load("b.png");
                    pictureBox4.Load("o.png");
                    pictureBox5.Load("o.png");
                    pictureBox6.Load("o.png");
                    pictureBox3.Load("o.png");


                    pictureBox7.Load("o.png");
                    pictureBox8.Load("o.png");
                    pictureBox9.Load("o.png");
                    pictureBox10.Load("o.png");
                    pictureBox11.Load("o.png");

                    pictureBox12.Load("o.png");
                    pictureBox13.Load("o.png");
                    pictureBox14.Load("o.png");

                    break;
            }




           




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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
