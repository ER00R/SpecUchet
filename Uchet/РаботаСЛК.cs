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
    public partial class РаботаСЛК : MaterialForm
    {
        public РаботаСЛК()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.Профессии". При необходимости она может быть перемещена или удалена.
            this.профессииTableAdapter.Fill(this.uchetBaseDataSet.Профессии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.Пол". При необходимости она может быть перемещена или удалена.
            this.полTableAdapter.Fill(this.uchetBaseDataSet.Пол);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.Подразделения". При необходимости она может быть перемещена или удалена.
            this.подразделенияTableAdapter.Fill(this.uchetBaseDataSet.Подразделения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.uchetBaseDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.ТиповыеНормы". При необходимости она может быть перемещена или удалена.
            this.типовыеНормыTableAdapter.Fill(this.uchetBaseDataSet.ТиповыеНормы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.СведенияОВыдачеСИЗ". При необходимости она может быть перемещена или удалена.
            this.сведенияОВыдачеСИЗTableAdapter.Fill(this.uchetBaseDataSet.СведенияОВыдачеСИЗ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.ЛичнаяКарточка". При необходимости она может быть перемещена или удалена.
            this.личнаяКарточкаTableAdapter.Fill(this.uchetBaseDataSet.ЛичнаяКарточка);

            if (data.mode == 1) личнаяКарточкаBindingSource.AddNew();
            if (data.mode == 2)
            {
                int pos = личнаяКарточкаBindingSource.Find("КодЛичнаяКарточка", data.kod);
                личнаяКарточкаBindingSource.Position = pos;
            }
            if (data.mode == 3)
            {
                int pos = личнаяКарточкаBindingSource.Find("КодЛичнаяКарточка", data.kod);
                личнаяКарточкаBindingSource.Position = pos;
                materialDivider2.Enabled = false;
            }
           // data.kod = 0;



        }

        private void личнаяКарточкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.личнаяКарточкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchetBaseDataSet);

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void профессияComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void профессияComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var = Convert.ToString(профессияComboBox.SelectedIndex+1);
            this.типовыеНормыTableAdapter.ЗапросЛК(this.uchetBaseDataSet.ТиповыеНормы, var);
        }

        private void materialDivider5_Click(object sender, EventArgs e)
        {


        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.личнаяКарточкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchetBaseDataSet);
        }
    }
}
