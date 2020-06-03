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
    public partial class РаботаСЛКОборот : MaterialForm
    {
        public РаботаСЛКОборот()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.ВыдачаСИЗ". При необходимости она может быть перемещена или удалена.
            this.выдачаСИЗTableAdapter.Fill(this.uchetBaseDataSet.ВыдачаСИЗ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.ВыдачаСИЗ". При необходимости она может быть перемещена или удалена.
            this.выдачаСИЗTableAdapter.Fill(this.uchetBaseDataSet.ВыдачаСИЗ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.СИЗ". При необходимости она может быть перемещена или удалена.
            this.сИЗTableAdapter.Fill(this.uchetBaseDataSet.СИЗ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.СведенияОВыдачеСИЗ". При необходимости она может быть перемещена или удалена.
            this.сведенияОВыдачеСИЗTableAdapter.Fill(this.uchetBaseDataSet.СведенияОВыдачеСИЗ);

        }

        private void сведенияОВыдачеСИЗBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сведенияОВыдачеСИЗBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchetBaseDataSet);

        }
    }
}
