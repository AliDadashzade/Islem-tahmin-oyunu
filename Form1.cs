using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islem_tahmin_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random=new Random();
        int num1, num2, res, proc, point=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int time = 60;

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label8.Text = time.ToString();
            if (time == 0)
            {
                MessageBox.Show("Oyun Bitdi! "+"Neticeniz="+label7.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            textBox1.Clear();
            label5.Visible = false;
            button1.Text = "Novbeti->";
            button1.Enabled = false;
            textBox1.Enabled = true;
            button2.Enabled = true;
            proc=random.Next(1,5);
            num1=random.Next(1,100);
            num2=random.Next(1,100);
            label1.Text = num1.ToString();
            label3.Text = num2.ToString();
            if (proc == 1)
            {
                label2.Text = "+";
                res = num1 + num2;
                label5.Text = res.ToString();
            }
            else if (proc == 2)
            {
                label2.Text = "-";
                res = num1 - num2;
                label5.Text = res.ToString();
            }
            if (proc == 3)
            {
                label2.Text = "*";
                res = num1 * num2;
                label5.Text = res.ToString();
            }
            if (proc == 4)
            {
                label2.Text = "/";
                res = num1 / num2;
                label5.Text = res.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label5.Visible = true;
            button2.Enabled = false;
            button1.Enabled=true;
            if (textBox1.Text == label5.Text)
            {
                pictureBox1.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Islem tahmin oyunu\\download.png";
                point += 10;
                label7.Text = point.ToString();
            }
            else
            {
                pictureBox1.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Islem tahmin oyunu\\download (1).png";
                point -= 5;
                label7.Text=point.ToString();
            }
        }


    }
}
