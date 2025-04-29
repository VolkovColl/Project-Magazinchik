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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void поставщикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.магазин_ОдеждыDataSet.Поставщики);

        }

        private void телефонTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.поставщикиBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.поставщикиBindingSource.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.поставщикиBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.поставщикиBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.поставщикиBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
