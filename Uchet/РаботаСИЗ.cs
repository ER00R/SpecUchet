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
    public partial class РаботаСИЗ : MaterialForm
    {
        public РаботаСИЗ()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.СИЗ". При необходимости она может быть перемещена или удалена.
            this.сИЗTableAdapter.Fill(this.uchetBaseDataSet.СИЗ);

        }

        private void сИЗBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сИЗBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchetBaseDataSet);

        }
    }
}
