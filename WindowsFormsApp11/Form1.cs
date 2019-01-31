using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        string number;
        List<string> cultureList = new List<string>();
        CultureInfo[] cultureInfos = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           




            foreach (CultureInfo  culture in cultureInfos)
            {
                region = new RegionInfo(culture.LCID);
                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                    CountryCB.Items.Add(region.EnglishName + "(" + region.TwoLetterISORegionName + ")");
                }
            }

            Tactic.Items.Add("4-4-2");
            Tactic.Items.Add("4-3-3");
            Tactic.Items.Add("3-4-3");
           
        }

        private void CountryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void Tactic_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (Tactic.SelectedItem)
            {
            
                case "4-4-2":
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    radioButton5.Enabled = true;
                    radioButton6.Enabled = true;
                    radioButton7.Enabled = true;
                    radioButton8.Enabled = true;
                    radioButton9.Enabled = true;
                    radioButton10.Enabled = true;
                    radioButton11.Enabled = true;

                    Name1.Enabled = true;
                    Name2.Enabled = true;
                    Name3.Enabled = true;
                    Name4.Enabled = true;
                    Name5.Enabled = true;
                    Name6.Enabled = true;
                    Name7.Enabled = true;
                    Name8.Enabled = true;
                    Name9.Enabled = true;
                    Name10.Enabled = true;
                    Name11.Enabled = true;

                    Number1.Enabled = true;
                    Number2.Enabled = true;
                    Number3.Enabled = true;
                    Number4.Enabled = true;
                    Number5.Enabled = true;
                    Number6.Enabled = true;
                    Number7.Enabled = true;
                    Number8.Enabled = true;
                    Number9.Enabled = true;
                    Number10.Enabled = true;
                    Number11.Enabled = true;



                    Position1.Text = "GK";
                    Position2.Text = "LB";
                    Position3.Text = "CB";
                    Position4.Text = "CB";
                    Position5.Text = "RB";
                    Position6.Text = "LM";
                    Position7.Text = "CM";
                    Position8.Text = "CM";
                    Position9.Text = "RM";
                    Position10.Text = "ST";
                    Position11.Text = "ST";


                    break;
                case "4-3-3":
                    Name1.Enabled = true;
                    Name2.Enabled = true;
                    Name3.Enabled = true;
                    Name4.Enabled = true;
                    Name5.Enabled = true;
                    Name6.Enabled = true;
                    Name7.Enabled = true;
                    Name8.Enabled = true;
                    Name9.Enabled = true;
                    Name10.Enabled = true;
                    Name11.Enabled = true;

                    Number1.Enabled = true;
                    Number2.Enabled = true;
                    Number3.Enabled = true;
                    Number4.Enabled = true;
                    Number5.Enabled = true;
                    Number6.Enabled = true;
                    Number7.Enabled = true;
                    Number8.Enabled = true;
                    Number9.Enabled = true;
                    Number10.Enabled = true;
                    Number11.Enabled = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    radioButton5.Enabled = true;
                    radioButton6.Enabled = true;
                    radioButton7.Enabled = true;
                    radioButton8.Enabled = true;
                    radioButton9.Enabled = true;
                    radioButton10.Enabled = true;
                    radioButton11.Enabled = true;
                    Position1.Text = "GK";
                    Position2.Text = "LB";
                    Position3.Text = "CB";
                    Position4.Text = "CB";
                    Position5.Text = "RB";
                    Position6.Text = "LM";
                    Position7.Text = "CM";
                    Position8.Text = "RM";
                    Position9.Text = "LW";
                    Position10.Text = "ST";
                    Position11.Text = "RW";



                    break;
                case "3-4-3":
                    Name1.Enabled = true;
                    Name2.Enabled = true;
                    Name3.Enabled = true;
                    Name4.Enabled = true;
                    Name5.Enabled = true;
                    Name6.Enabled = true;
                    Name7.Enabled = true;
                    Name8.Enabled = true;
                    Name9.Enabled = true;
                    Name10.Enabled = true;
                    Name11.Enabled = true;

                    Number1.Enabled = true;
                    Number2.Enabled = true;
                    Number3.Enabled = true;
                    Number4.Enabled = true;
                    Number5.Enabled = true;
                    Number6.Enabled = true;
                    Number7.Enabled = true;
                    Number8.Enabled = true;
                    Number9.Enabled = true;
                    Number10.Enabled = true;
                    Number11.Enabled = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    radioButton5.Enabled = true;
                    radioButton6.Enabled = true;
                    radioButton7.Enabled = true;
                    radioButton8.Enabled = true;
                    radioButton9.Enabled = true;
                    radioButton10.Enabled = true;
                    radioButton11.Enabled = true;
                    Position1.Text = "GK";
                    Position2.Text = "LB";
                    Position3.Text = "CB";
                    Position4.Text = "RB";
                    Position5.Text = "LM";
                    Position6.Text = "CM";
                    Position7.Text = "CM";
                    Position8.Text = "RM";
                    Position9.Text = "LW";
                    Position10.Text = "ST";
                    Position11.Text = "RW";

                   
                    break;
            }
        }

        private void GenerateTeam_Click(object sender, EventArgs e)
        {




            Number1.BackColor = Color.White;
            Number2.BackColor = Color.White;
            Number3.BackColor = Color.White;
            Number4.BackColor = Color.White;
            Number5.BackColor = Color.White;
            Number6.BackColor = Color.White;
            Number7.BackColor = Color.White;
            Number8.BackColor = Color.White;
            Number9.BackColor = Color.White;
            Number10.BackColor = Color.White;
            Number11.BackColor = Color.White;

            Name1.BackColor = Color.White;
            Name2.BackColor = Color.White;

            Name3.BackColor = Color.White;

            Name4.BackColor = Color.White;

            Name5.BackColor = Color.White;

            Name6.BackColor = Color.White;

            Name7.BackColor = Color.White;

            Name8.BackColor = Color.White;

            Name9.BackColor = Color.White;
            Name10.BackColor = Color.White;
            Name11.BackColor = Color.White;

            

            List<string> List = new List<string>();
            List.Add(Number1.Text);
            List.Add(Number2.Text);
            List.Add(Number3.Text);
            List.Add(Number4.Text);
            List.Add(Number5.Text);
            List.Add(Number6.Text);
            List.Add(Number7.Text);
            List.Add(Number8.Text);
            List.Add(Number9.Text);
            List.Add(Number10.Text);
            List.Add(Number11.Text);
            List<string> list = new List<string>();
            list.Add(Name1.Text);
            list.Add(Name2.Text);
            list.Add(Name3.Text);
            list.Add(Name4.Text);
            list.Add(Name5.Text);
            list.Add(Name6.Text);
            list.Add(Name7.Text);
            list.Add(Name8.Text);
            list.Add(Name9.Text);
            list.Add(Name10.Text);
            list.Add(Name11.Text);
            bool L=true;
            bool l = true;
            foreach (var item in List)
            {
                if(item.ToString()==string.Empty)
                {
                    L = false;
                }
                if(Int32.TryParse(item.ToString(),out int p )==false)
                {
                    L = false;
                }
                
            }
            for (int i = 0; i < List.Count; i++)
            {
                for (int j = i+1; j < List.Count; j++)
                {
                    if(List[i]==List[j])
                    {
                        L = false;
                    }
                }


            }
            foreach (var item in list)
            {
                if(item.ToString()==string.Empty)
                {
                    l = false;
                }
            }

            if (L && l && number!=string.Empty)
            {


                bool a = false;
                string b = "";
                string c = "";
                foreach (var item in CountryCB.SelectedItem.ToString())
                {
                    if (item.ToString() == ")")
                    {
                        a = false;
                    }
                    if (a)
                    {
                        b += item.ToString();
                    }
                    if (item.ToString() == "(")
                    {
                        a = true;
                    }
                    if (!a && item.ToString() != ")")
                    {
                        c += item.ToString();

                    }

                }
               

                Form2 form2 = new Form2(b, c, Tactic.SelectedItem.ToString(), List, list,number);
                form2.ShowDialog();
            }
            else
            {
                if(Number1.Text==string.Empty || Int32.TryParse(Number1.Text,out int p)==false)
                {
                    Number1.BackColor = Color.Red;
                }
                if (Number2.Text == string.Empty || Int32.TryParse(Number2.Text, out int y) == false)
                {
                    Number2.BackColor = Color.Red;
                }
                if (Number3.Text == string.Empty || Int32.TryParse(Number3.Text, out int pas) == false)
                {
                    Number3.BackColor = Color.Red;
                }
                if (Number4.Text == string.Empty || Int32.TryParse(Number4.Text, out int pasdf) == false)
                {
                    Number4.BackColor = Color.Red;
                }
                if (Number5.Text == string.Empty || Int32.TryParse(Number1.Text, out int pdgf) == false)
                {
                    Number5.BackColor = Color.Red;
                }
                if (Number6.Text == string.Empty || Int32.TryParse(Number6.Text, out int pfgh) == false)
                {
                    Number6.BackColor = Color.Red;
                }
                if (Number7.Text == string.Empty || Int32.TryParse(Number7.Text, out int pcbc) == false)
                {
                    Number7.BackColor = Color.Red;
                }
                if (Number8.Text == string.Empty || Int32.TryParse(Number8.Text, out int phjk) == false)
                {
                    Number8.BackColor = Color.Red;
                }
                if (Number9.Text == string.Empty || Int32.TryParse(Number9.Text, out int phjkw) == false)
                {
                    Number9.BackColor = Color.Red;
                }
                if (Number10.Text == string.Empty || Int32.TryParse(Number10.Text, out int pfgdgd) == false)
                {
                    Number10.BackColor = Color.Red;
                }
                if (Number11.Text == string.Empty || Int32.TryParse(Number11.Text, out int tuytu) == false)
                {
                    Number11.BackColor = Color.Red;
                }



                if(Name1.Text==string.Empty)
                {
                    Name1.BackColor = Color.Red;
                }
                if (Name2.Text == string.Empty)
                {
                    Name2.BackColor = Color.Red;
                }
                if (Name3.Text == string.Empty)
                {
                    Name3.BackColor = Color.Red;
                }
                if (Name4.Text == string.Empty)
                {
                    Name4.BackColor = Color.Red;
                }
                if (Name5.Text == string.Empty)
                {
                    Name5.BackColor = Color.Red;
                }
                if (Name6.Text == string.Empty)
                {
                    Name6.BackColor = Color.Red;
                }
                if (Name7.Text == string.Empty)
                {
                    Name7.BackColor = Color.Red;
                }
                if (Name8.Text == string.Empty)
                {
                    Name8.BackColor = Color.Red;
                }
                if (Name9.Text == string.Empty)
                {
                    Name9.BackColor = Color.Red;
                }
                if (Name10.Text == string.Empty)
                {
                    Name10.BackColor = Color.Red;
                }
                if (Name11.Text == string.Empty)
                {
                    Name11.BackColor = Color.Red;

                }

            }






        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox5";

            // number = radioButton1.Text;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox7";

            // number = radioButton2.Text;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox10";

            //number = radioButton3.Text;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox11";

            // number = radioButton4.Text;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox12";

            // number = radioButton5.Text;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox3";

            // number = radioButton6.Text;

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox9";

            //  number = radioButton7.Text;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox6";

            // number = radioButton8.Text;

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox8";

            //number = radioButton9.Text;

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox13";

            //number = radioButton10.Text;

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            number = string.Empty;
            number = "pictureBox14";

            // number = radioButton11.Text;

        }
    }
}
