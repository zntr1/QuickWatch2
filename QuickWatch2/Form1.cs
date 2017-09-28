using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

// zntr1, Phil P
namespace QuickWatch2
{
    public partial class Form1: Form
    {

        private bool mouseDown;
        private Point lastLocation;


        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (ActiveForm != null)
                {
                    ActiveForm.Location = new Point((ActiveForm.Location.X - lastLocation.X) + e.X, (ActiveForm.Location.Y - lastLocation.Y) + e.Y);
                    ActiveForm.Update();
                }
            }
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e){
            if (mouseDown){
                if (ActiveForm != null){
                    ActiveForm.Location = new Point((ActiveForm.Location.X - lastLocation.X) + e.X,
                        (ActiveForm.Location.Y - lastLocation.Y) + e.Y);
                    ActiveForm.Update();
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(500);
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (ActiveForm != null)
                {
                    ActiveForm.Location = new Point((ActiveForm.Location.X - lastLocation.X) + e.X,
                        (ActiveForm.Location.Y - lastLocation.Y) + e.Y);
                    ActiveForm.Update();
                }
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                // gegen Beeps und autoclose
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (toolStripTextBox1.Text == "")
                { return; }
                   

                HtmlWeb web = new HtmlWeb();
                var doc = await Task.Factory.StartNew(() => web.Load(@"https://bs.to/serie-alphabet"));
                var nodes = doc.DocumentNode.SelectNodes("//*[@id=\"seriesContainer\"]//div");
                foreach (var node in nodes)
                {
                    if (node.InnerText.ToLower().Contains(toolStripTextBox1.Text.ToLower()))
                    {

                        var innerHtmlString = node.InnerHtml;
                        innerHtmlString = innerHtmlString.Replace("<li>", "");
                        innerHtmlString = innerHtmlString.Replace("</li>", "");
                        innerHtmlString = innerHtmlString.Replace("<ul>", "");
                        innerHtmlString = innerHtmlString.Replace("</ul>", "");
                        innerHtmlString = innerHtmlString.Replace("<a href=\"", "");

                        var innerHtmlList = innerHtmlString.Split('\n').ToList();

                        foreach (var rowInformation in innerHtmlList)
                        {
                            if (!rowInformation.ToLower().Contains(toolStripTextBox1.Text.ToLower()))
                            {
                                continue;
                            }
                            var rowInfoList = rowInformation.Split('"').ToList();
                            if (rowInfoList.Count < 2)
                            {
                                continue;
                            }

                            var link = rowInfoList.ElementAt(0).Trim();
                            link = "www.bs.to/" + link;

                            Process.Start(link);
                            toolStripTextBox1.Clear();
                            return;
                        }
                    }
                }
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left){
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
            }
            
        }
    }
}
