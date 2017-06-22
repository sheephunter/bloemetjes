using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muziekieApp
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Jaspe\Source\Repos\bloemetjes\muziekieApp\m.wav");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hier komen de liedjes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Backward
        }

        private void BtnShuffle_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            try{
                //player.SoundLocation = @"C:\Users\Jaspe\Source\Repos\bloemetjes\muziekieApp\m.wav";
                player.Play();
            }
            catch (Exception)
            {
                MessageBox.Show("enaa g is fout na g");
            }
        }
    }
}
