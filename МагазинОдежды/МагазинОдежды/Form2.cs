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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void тип_одеждыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_одеждыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet1);

        }

        private void тип_одеждыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_одеждыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet1.Таблица". При необходимости она может быть перемещена или удалена.
            this.таблицаTableAdapter.Fill(this.магазин_ОдеждыDataSet1.Таблица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet1.Тип_одежды". При необходимости она может быть перемещена или удалена.
            this.тип_одеждыTableAdapter.Fill(this.магазин_ОдеждыDataSet1.Тип_одежды);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.тип_одеждыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.тип_одеждыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.тип_одеждыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.тип_одеждыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.тип_одеждыBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.тип_одеждыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_одеждыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.тип_одеждыTableAdapter1.FillBy(this.магазин_ОдеждыDataSet.Тип_одежды);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
