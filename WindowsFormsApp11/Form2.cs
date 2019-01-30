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
        public Form2(string text,string Name,string Tactic,List<string> list,List<string>List)
        {
            InitializeComponent();
            pictureBox1.Load($"https://countryflags.io/{text}/shiny/64.png");
            label.Font = new Font("Calibri", 24);
            label.Text = Name;

            switch (Tactic)
            {
                case "4-4-2":
                    label21.Text = List[0];  
                label20.Text = List[1];
                    label19.Text = List[2];
                    label18.Text = List[3];
                    label17.Text = List[4];
                    label16.Text = List[5];
                    label15.Text = List[6];
                    label14.Text = List[7];
                    label13.Text = List[8];
                    label12.Text = List[9];
                    label11.Text = List[10];

                    label11.BackColor = Color.FromArgb(0, 128, 1);
                    label12.BackColor = Color.FromArgb(0, 128, 1);
                    label13.BackColor = Color.FromArgb(0, 128, 1);
                    label14.BackColor = Color.FromArgb(0, 128, 1);
                    label15.BackColor = Color.FromArgb(0, 128, 1);
                    label16.BackColor = Color.FromArgb(0, 128, 1);
                    label17.BackColor = Color.FromArgb(0, 128, 1);
                    label18.BackColor = Color.FromArgb(0, 128, 1);
                    label19.BackColor = Color.FromArgb(0, 128, 1);
                    label20.BackColor = Color.FromArgb(0, 128, 1);
                    label21.BackColor = Color.FromArgb(0, 128, 1);







                    label0.BackColor = Color.FromArgb(241,229,169);
                    label0.Text = list[0];
                    label1.Text = list[1];
                    label1.BackColor = Color.FromArgb(241, 229, 169);

                    label2.BackColor = Color.FromArgb(241, 229, 169);
                    label2.Text = list[2];
                    label3.Text = list[3];
                    label3.BackColor = Color.FromArgb(241, 229, 169);

                    label4.BackColor = Color.FromArgb(241, 229, 169);
                    label4.Text = list[4];
                    label5.Text = list[5];
                    label5.BackColor = Color.FromArgb(241, 229, 169);

                    label6.BackColor = Color.FromArgb(241, 229, 169);
                    label6.Text = list[6];
                    label7.Text = list[7];
                    label7.BackColor = Color.FromArgb(241, 229, 169);

                    label8.BackColor = Color.FromArgb(241, 229, 169);
                    label8.Text = list[8];
                    label9.Text = list[9];
                    label9.BackColor = Color.FromArgb(241, 229, 169);

                    label10.BackColor = Color.FromArgb(241, 229, 169);
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

                    label21.Text = List[0];
                    label20.Text = List[1];
                    label19.Text = List[2];
                    label18.Text = List[3];
                    label17.Text = List[4];
                    label16.Text = List[5];
                    label15.Text = List[6];
                    label13.Text = List[7];
                    label11.Text = List[8];
                    label14.Text = List[9];
                    label12.Text = List[10];

                    label11.BackColor = Color.FromArgb(0, 128, 1);
                    label12.BackColor = Color.FromArgb(0, 128, 1);
                    label13.BackColor = Color.FromArgb(0, 128, 1);
                    label14.BackColor = Color.FromArgb(0, 128, 1);
                    label15.BackColor = Color.FromArgb(0, 128, 1);
                    label16.BackColor = Color.FromArgb(0, 128, 1);
                    label17.BackColor = Color.FromArgb(0, 128, 1);
                    label18.BackColor = Color.FromArgb(0, 128, 1);
                    label19.BackColor = Color.FromArgb(0, 128, 1);
                    label20.BackColor = Color.FromArgb(0, 128, 1);
                    label21.BackColor = Color.FromArgb(0, 128, 1);







                    pictureBox9.Location = new Point(615, 37);
                    label14.Location = new Point(615, 87);
                    pictureBox6.Location = new Point(608, 200);
                    label15.Location = new Point(608, 257);
                    label6.Location = new Point(625, 215);
                    label7.Location = new Point(630,48);
                    label0.BackColor = Color.FromArgb(241, 229, 169);
                    label0.Text = list[0];
                    label1.Text = list[1];
                    label1.BackColor = Color.FromArgb(241, 229, 169);

                    label2.BackColor = Color.FromArgb(241, 229, 169);
                    label2.Text = list[2];
                    label3.Text = list[3];
                    label3.BackColor = Color.FromArgb(241, 229, 169);

                    label4.BackColor = Color.FromArgb(241, 229, 169);
                    label4.Text = list[4];
                    label5.Text = list[5];
                    label5.BackColor = Color.FromArgb(241, 229, 169);

                    label6.BackColor = Color.FromArgb(241, 229, 169);
                    label6.Text = list[6];
                    label7.Text = list[7];
                    label7.BackColor = Color.FromArgb(241, 229, 169);

                    label8.BackColor = Color.FromArgb(241, 229, 169);
                    label8.Text = list[8];
                    label9.Text = list[9];
                    label9.BackColor = Color.FromArgb(241, 229, 169);

                    label10.BackColor = Color.FromArgb(241, 229, 169);
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
                case "3-4-3":

                    label21.Text = List[0];
                    label20.Text = List[1];
                    label19.Text = List[3];
                    label18.Text = List[2];
                    label17.Text = List[5];
                    label16.Text = List[5];
                    label15.Text = List[5];
                    //label13.Text = List[7];
                    //label11.Text = List[8];
                    //label14.Text = List[9];
                    //label12.Text = List[10];

                    label11.BackColor = Color.FromArgb(0, 128, 1);
                    label12.BackColor = Color.FromArgb(0, 128, 1);
                    label13.BackColor = Color.FromArgb(0, 128, 1);
                    label14.BackColor = Color.FromArgb(0, 128, 1);
                    label15.BackColor = Color.FromArgb(0, 128, 1);
                    label16.BackColor = Color.FromArgb(0, 128, 1);
                    label17.BackColor = Color.FromArgb(0, 128, 1);
                    label18.BackColor = Color.FromArgb(0, 128, 1);
                    label19.BackColor = Color.FromArgb(0, 128, 1);
                    label20.BackColor = Color.FromArgb(0, 128, 1);
                    label21.BackColor = Color.FromArgb(0, 128, 1);









                    pictureBox11.Location = new Point(615, 37);
                    label19.Location = new Point(615, 87);
                    pictureBox10.Location = new Point(608, 348);
                    label18.Location = new Point(608, 398);
                    label2.Location = new Point(624, 362);
                    label3.Location = new Point(630, 48);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
