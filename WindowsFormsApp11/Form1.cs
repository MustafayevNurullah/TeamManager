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
            bool a=false;
            string b="";
            string c = "";
            foreach (var item in CountryCB.SelectedItem.ToString())
            {
                if(item.ToString()==")")
                {
                    a = false;
                }
                if(a)
                {
                    b += item.ToString();
                }
                if(item.ToString()=="(")
                {
                    a = true;
                }
                if(!a && item.ToString()!=")" )
                {
                    c += item.ToString();

                }

            }
          
            Form2 form2 = new Form2(b,c,Tactic.SelectedItem);
            form2.ShowDialog();







        }
       

       
    }
}
