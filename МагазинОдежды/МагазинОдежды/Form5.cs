using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МагазинОдежды
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.магазин_ОдеждыDataSet1.Сотрудники);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveFirst();
        }
    }
}
