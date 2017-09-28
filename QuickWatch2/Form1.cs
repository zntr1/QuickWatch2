using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

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
            Application.Exit();
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
    }
}
