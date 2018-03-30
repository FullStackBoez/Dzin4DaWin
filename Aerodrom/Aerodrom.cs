using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodrom
{
    public partial class Аеродроми : Form
    {
        private Dictionary<string, List<string>> list=new Dictionary<string, List<string>>();
        public Аеродроми()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nov_aerodrom na = new Nov_aerodrom();
            na.ShowDialog();
            if (na.item != "")
            {
                
                if (!list.ContainsKey(na.item))
                {
                    listBox1.Items.Add(na.item);
                    list.Add(na.item,new List<string>());
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          DialogResult dr=  MessageBox.Show( "Дали сте сигурни?", "Бришење", MessageBoxButtons.YesNo);
            if (dr==DialogResult.Yes)
            {
                list[listBox1.SelectedItem.ToString()] = null;
                list.Remove(listBox1.SelectedItem.ToString());
                listBox1.DataSource = null;
                listBox2.DataSource = null;
                listBox1.DataSource = list.Keys.ToList<string>();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Nova_Destinacija nd = new Nova_Destinacija();
            nd.ShowDialog();
            if (nd.item!="")
            {
                List<string> li;
                list.TryGetValue(listBox1.SelectedItem.ToString(), out li);
                li.Add(nd.item);
                list[listBox1.SelectedItem.ToString()] = li;
                listBox2.DataSource = null;
                listBox2.DataSource = li;
                presmetaj();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            List<string> li;
            list.TryGetValue(listBox1.SelectedItem.ToString(),out li);
            listBox2.DataSource = null;
            listBox2.DataSource = li;
            presmetaj();
        }
        private void presmetaj()
        {
            List<string> li;
            list.TryGetValue(listBox1.SelectedItem.ToString(), out li);
            double max = double.MinValue;
            double avg = 0.0;
            int count = 0;
            string ss = "";
            foreach (string s in li)
            {
                string sa = s.Replace("-", "");
                string[] nova = System.Text.RegularExpressions.Regex.Split(sa, "\\s+");
                foreach (string x in nova)
                {
                    if (x.EndsWith("km"))
                    {
                        avg += Convert.ToDouble(x.Replace("km",""));
                        count++;
                    }
                    else if (x.EndsWith("EUR"))
                    {
                        if(max<= Convert.ToDouble(x.Replace("EUR", "")))
                        {
                            max = Convert.ToDouble(x.Replace("EUR", ""));
                            ss = s;
                        }
                        
                    }

                }
            }
            textBox1.Text = ss;
            if (count  == 0) return;
            textBox2.Text = string.Format("{0:.0}",(double)(avg / count));

        }
    }
}
