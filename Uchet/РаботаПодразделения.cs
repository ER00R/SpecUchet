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
    public partial class РаботаПодразделения : MaterialForm
    {
        public РаботаПодразделения()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.Подразделения". При необходимости она может быть перемещена или удалена.
            this.подразделенияTableAdapter.Fill(this.uchetBaseDataSet.Подразделения);

        }

        private void подразделенияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.подразделенияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchetBaseDataSet);

        }
    }
}
