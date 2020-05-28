using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;


namespace Uchet
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            materialRaisedButton1.BackColor = Color.FromArgb(225, 225, 225);
            materialLabel1.ForeColor = Color.White;
            materialLabel2.ForeColor = Color.White;
            materialLabel3.ForeColor = Color.White;
            materialLabel3.BackColor = Color.FromArgb(38, 50, 56);
            Form2 fz = new Form2();
            fz.ShowDialog();



        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Convert.ToString(DateTime.Now);
        }

        private void button9_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            Form7 fz = new Form7();
            fz.Show();
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            materialLabel3.Text = "Сотрудники";
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {
            materialLabel3.Text = "Личные карты";
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            materialLabel3.Text = "Средства индивидуальной защиты";
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            materialLabel3.Text = "Склад";
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {

        }
    }
}
