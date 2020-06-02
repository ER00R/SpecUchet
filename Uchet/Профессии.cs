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
    public partial class Профессии : MaterialForm
    {
        public Профессии()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.Профессии". При необходимости она может быть перемещена или удалена.
            this.профессииTableAdapter.Fill(this.uchetBaseDataSet.Профессии);

        }

        private void профессииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.профессииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchetBaseDataSet);

        }
    }
}
