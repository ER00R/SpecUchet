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
    public partial class РаботаТиповыеНормы : MaterialForm
    {
        public РаботаТиповыеНормы()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.ТиповыеНормы". При необходимости она может быть перемещена или удалена.
            this.типовыеНормыTableAdapter.Fill(this.uchetBaseDataSet.ТиповыеНормы);

        }

        private void типовыеНормыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типовыеНормыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchetBaseDataSet);

        }
    }
}
