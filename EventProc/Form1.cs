using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventProc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

  

            Button btn = (Button)sender;

            switch (btn.Name) {
                case "button1":
                    break;
                case "button2":
                    break;

            }

            btn.Text = "빠방 선택함";
            btn.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "♧";
            label1.Text += "↔";

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse X :" + e.X + " / Y :" + e.Y; 
        }

        private int elapsedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            textBox1.Text = ""+elapsedTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elapsedTime = 0;
            textBox1.Enabled = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            elapsedTime = 0;
            textBox1.Enabled = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
        }
    }
}
