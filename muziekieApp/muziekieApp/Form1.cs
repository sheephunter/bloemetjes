using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public string songs;
        public string rLink;

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
            rLink = getrandomfile2(@"C:\Users\Jaspe\Source\Repos\bloemetjes\muziekieApp");

            player.SoundLocation = rLink;
            player.Play();

            //var rand = new Random();
            //var files = Directory.GetFiles(@"C:\Users\Jaspe\Source\Repos\bloemetjes\muziekieApp", " *.wav");
            //try
            //{
            //    songs = files[rand.Next(files.Length)];
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("kill yourself");
            //}
            //MessageBox.Show(songs);

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

        private void Btnreplay_Click(object sender, EventArgs e)
        {
            player.PlayLooping();
        }


        public string getrandomfile2(string path)
        {
            string file = null;
            if (!string.IsNullOrEmpty(path))
            {
                var extensions = new string[] { ".wav" };
                try
                {
                    var di = new DirectoryInfo(path);
                    var rgFiles = di.GetFiles("*.*").Where(f => extensions.Contains(f.Extension.ToLower()));
                    Random R = new Random();
                    file = rgFiles.ElementAt(R.Next(0, rgFiles.Count())).FullName;
                }
                // probably should only catch specific exceptions
                // throwable by the above methods.
                catch { }
            }
            return file;
        }
    }
}
