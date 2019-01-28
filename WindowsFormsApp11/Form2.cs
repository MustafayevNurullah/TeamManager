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

            switch (Tactic)
            {
                case "4-4-2":
                    
                    
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



                    break;
                case "3-4-3":
                   
                    pictureBox11.Location = new Point(615, 37);  
                    pictureBox10.Location = new Point(608, 348);
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
    }
}
