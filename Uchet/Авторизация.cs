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
    public partial class Авторизация : MaterialForm
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetBaseDataSet.АвторизационныеДанные". При необходимости она может быть перемещена или удалена.
            this.авторизационныеДанныеTableAdapter.Fill(this.uchetBaseDataSet.АвторизационныеДанные);

        }

        private void авторизационныеДанныеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.авторизационныеДанныеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchetBaseDataSet);


        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            ГлавнаяЛК лК = new ГлавнаяЛК();
            лК.Show();
            if (materialRaisedButton1.Text != "") { }
            else
               if (materialRaisedButton1.Text == Convert.ToString(авторизационныеДанныеDataGridView.Rows[0].Cells[1].Value))
            {
                лК.Show();
                this.Close();
            }
            else { MessageBox.Show("Wrong password"); };

        }
    }
}
