using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dnd_Archtype_Item
{
    public partial class Form1 : Form
    {

        List<ArchitectDnd> listOfArchDnd = new List<ArchitectDnd>();

        BindingSource bs = new BindingSource();

        public Form1()
        {
            









            string filePath = @"C:\Users\xavie\Downloads\Class(Archetype).csv";

            // string [] lines = File.ReadAllLines(filePath);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            string last_arch = "";
            ArchitectDnd Arch = new ArchitectDnd();
            foreach (String line in lines)
            {
                Console.WriteLine(line);
                if (line.Split(',')[0] != last_arch){
                    if (Arch.Name != null)
                    {
                        listOfArchDnd.Add(Arch);
                    }
                    Arch =new ArchitectDnd();

                    Arch.Name = line.Split(',')[0];

                    Arch.ArchChildren.Add(line.Split(',')[1]);
                    last_arch=Arch.Name;
                }
                else
                {
                    Arch.ArchChildren.Add(line.Split(',')[1]);
                }
                string filePath2 = @"C:\Users\xavie\Downloads\DND.csv";

                string[] lines2 = File.ReadAllLines(filePath2);
                /*
                foreach (string line2 in lines2)
                {

                    lstItem.Items.Add(line2);
                }
                */
            }


            InitializeComponent();
            foreach (var a in listOfArchDnd)
            {
                cmbArch1.Items.Add(a.Name);
            }
            
        }
        private void cmbArch1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = cmbArch1.SelectedIndex;
            List<string> childrenArchDndList = new List<string>();

            List<string> currentChildren = listOfArchDnd[index].ArchChildren;
            foreach (var item in currentChildren)
            {
                childrenArchDndList.Add(item);
            }
            bs.DataSource = childrenArchDndList;
            cmbChildArchtype.DataSource = bs;
            bs.ResetBindings(false);

            string filePath2 = @"C:\Users\xavie\Downloads\DND.csv";

            string[] lines2 = File.ReadAllLines(filePath2);
            IDictionary<string, string[]> Link = new Dictionary<string, string[]>();

            Link["Artificer"]=new string[]{"Simple","light","Medium"};
            Link["Barbarian"]=new string[]{ "Light", "Medium", "Shields", "Simple","Martial"};
            Link["Bard"] = new string[]{ "Light", "Simple" };
            Link["Cleric"] = new string[]{ "light", "Medium", "Shields", "Simple" };
            Link["Druid"] = new string[] { "Light","Medium","Sheilds","Simple" };
            Link["Fighter"] = new string[] {"Light","Medium","Heavy","Shields","Simple","Martial" };
            Link["Monk"] = new string[] { "Simple"};
            Link["Paladin"] = new string[] {"Light","Medium","Heavy","Shields","Simple","Martial" };
            Link["Ranger"] = new string[] {"Light","Medium","Shield" };
            Link["Rogue"] = new string[] {"Light","Simple" };
            Link["Sorcerer"] = new string[] { };
            Link["Warlock"] = new string[] {"Light","Simple" };
            Link["Wizard"] = new string[] { };








            foreach (string line in lines2)
            {
                if (Link[cmbArch1.SelectedItem.ToString()].Contains(line.Split(',')[6]))
                {
                    lstItem.Items.Add(line);
                }
            }

        }

        private void cmbChildArchtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void lstItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
