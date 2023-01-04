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
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Linq;
using System.Threading;
namespace WindowsFormsApp1
{
    public partial class Minty : Form
    {
        bool useproxy;
        public Minty()
       
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;
        private void siticonePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void siticonePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private async void spam_ClickAsync(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(new ThreadStart(start));
                thread.Start();
            }
        }
        private async void start()
        {
                string fileName = "proxies.txt";
                string[] lines = File.ReadAllLines(fileName);
                Random rnd = new Random();
                int index = rnd.Next(lines.Length);
                string line = lines[index];
                for (int i = 0; i < 30; i++)
                {
                    string[] cproxy = line.Split(':');
                    int port = Int32.Parse(cproxy[1]);
                    WebProxy proxy = new WebProxy($"{cproxy[0]}", port);
                    HttpClientHandler handler = new HttpClientHandler();
                    handler.Proxy = proxy;
                if (useproxy)
                {
                    handler.UseProxy = true;
                } else
                {
                    handler.UseProxy = false;
                }
                    
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var json = new {content = $"{this.msg.Text}"};
                    string jsonString = JsonConvert.SerializeObject(json);
                    HttpContent content = new StringContent(jsonString);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    HttpResponseMessage response = await client.PostAsync(this.siticoneTextBox1.Text, content);
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                }
            }
        }

        private void siticoneToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.siticoneToggleSwitch1.Checked)
            {
                Console.WriteLine("Checked");
                useproxy = true;
            } else
            {
                Console.WriteLine("Not checked");
                useproxy = false;
            }
        }
    }
}
