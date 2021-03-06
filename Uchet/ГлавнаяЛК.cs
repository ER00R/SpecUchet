﻿using System;
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
    public partial class ГлавнаяЛК : MaterialForm
    {
        public ГлавнаяЛК()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.Подразделения". При необходимости она может быть перемещена или удалена.
            this.подразделенияTableAdapter.Fill(this.uchetBaseDataSet.Подразделения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.Профессии". При необходимости она может быть перемещена или удалена.
            this.профессииTableAdapter.Fill(this.uchetBaseDataSet.Профессии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.Пол". При необходимости она может быть перемещена или удалена.
            this.полTableAdapter.Fill(this.uchetBaseDataSet.Пол);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.uchetBaseDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.ЛичнаяКарточка". При необходимости она может быть перемещена или удалена.
            this.личнаяКарточкаTableAdapter.Fill(this.uchetBaseDataSet.ЛичнаяКарточка);
            timer1.Enabled = true;
            materialRaisedButton1.BackColor = Color.FromArgb(225, 225, 225);
            materialLabel1.ForeColor = Color.White;
            materialLabel2.ForeColor = Color.White;
            materialLabel3.ForeColor = Color.White;
            materialLabel3.BackColor = Color.FromArgb(38, 50, 56);
            Авторизация fz = new Авторизация();
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
            ТиповыеНормы fz = new ТиповыеНормы();
            fz.Show();
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            Сотрудники fz = new Сотрудники();
            fz.Show();
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {
            Подразделения fz = new Подразделения();
            fz.Show();
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            СИЗ fz = new СИЗ();
            fz.Show();
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            Профессии fz = new Профессии();
            fz.Show();
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            data.mode = 1;
            РаботаСЛК fz = new РаботаСЛК();
            fz.Show();

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            data.mode = 2;
            РаботаСЛК fz = new РаботаСЛК();
            fz.Show();

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            data.mode = 3;
            РаботаСЛК fz = new РаботаСЛК();
            fz.Show();

        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.личнаяКарточкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchetBaseDataSet);
        }
    }
}
