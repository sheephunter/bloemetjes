using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace dutch_combo_extracter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Jaspe\Source\Repos\bloemetjes\dutch combo extracter\input.txt");
        string comboCnt;
        string resultSTR;
        int resultCnt = 0;
        string filter;



        private void Form1_Load(object sender, EventArgs e)
        {
            comboCnt = Convert.ToString(lines.Length);
            label2.Text = "combos : "+ comboCnt +" loaded";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lines = System.IO.File.ReadAllLines(@"C:\Users\Jaspe\Source\Repos\bloemetjes\dutch combo extracter\input.txt");
            comboCnt = Convert.ToString(lines.Length);
            label2.Text = "combos : " + comboCnt + " loaded";
            //parsing txt file
            filter = textBox1.Text;
            if(!textBox1.Text.Equals(""))
            {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Jaspe\Source\Repos\bloemetjes\dutch combo extracter\combo\comboNL.txt", append: true))
            {
                foreach (string line in lines)
                {
                    // filtering
                    if (line.Contains(filter))
                    {
                        file.WriteLine(line);
                        resultCnt++;
                    }
                }
                resultSTR = Convert.ToString(resultCnt);
                label3.Text = "result : "+ resultSTR;
                MessageBox.Show("done filtering made a combo with "+ resultSTR +" entries");
            }
            }
            else
            {
                MessageBox.Show("enter something in the filter box!");
            }
        }
    }
}
