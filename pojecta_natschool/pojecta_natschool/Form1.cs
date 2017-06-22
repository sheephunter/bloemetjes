using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace pojecta_natschool
{
    public partial class Form1 : Form
    {
        public string url = "https://elo.horizoncollege.nl/";
        public string cookies;
        public string roosterURL;
        public string klasU;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WBnat.Navigate(url);
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            cookies = WBnat.Document.Cookie;
                MessageBox.Show(WBnat.Document.Cookie);
            
            WebClient natschool = new WebClient();
            string reply = natschool.DownloadString(new Uri("https://natschool.horizoncollege.nl/"));

            MessageBox.Show(reply);
            if (WBnat.Document.GetElementById("txtLoginId") != null && WBnat.Document.GetElementById("txtPassword") != null && userTXT.Text != null && passTXT.Text != null)
            {
                try
                {
                    WBnat.Document.GetElementById("txtLoginId").SetAttribute("value", userTXT.Text);
                    WBnat.Document.GetElementById("txtPassword").SetAttribute("value", passTXT.Text);
                }
                catch (Exception)
                {
                }
            }
            else
            {
                
            }
        }

        private void roosterBTN_Click(object sender, EventArgs e)
        {
            if (!numberTXT.Equals(""))
            {
                klasU = numberTXT.Text;
                MessageBox.Show(klasU);
                switch (klasU)
                {
                    case "IO1A":
                        roosterURL = "c00025.htm";
                        break;
                    case "IO1B":
                        roosterURL = "c00026.htm";
                        break;

                }
                WebClient WBrooster = new WebClient();
                string reply = WBrooster.DownloadString(new Uri("http://rooster.horizoncollege.nl/rstr/ECO/AMR/400-ECO/Roosters/24/c/" + roosterURL));

                MessageBox.Show(reply);
            }
        }
    }
}
