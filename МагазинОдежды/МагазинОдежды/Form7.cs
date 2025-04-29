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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.магазин_ОдеждыDataSet.Клиенты);

        }

        private void промокартаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.клиентыBindingSource.RemoveCurrent();
        }

        private void button7_Click_(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.клиентыBindingSource.RemoveCurrent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MoveFirst();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MoveNext();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.клиентыBindingSource.MoveLast();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.клиентыBindingSource.AddNew();
        }
    }
}