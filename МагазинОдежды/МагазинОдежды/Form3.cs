using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace МагазинОдежды
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void покупкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_Одежды161DataSet.Покупки". При необходимости она может быть перемещена или удалена.
            this.покупкиTableAdapter4.Fill(this.магазин_Одежды161DataSet.Покупки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_Одежды161DataSet.Покупки". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet3.Покупки". При необходимости она может быть перемещена или удалена.
            this.покупкиTableAdapter3.Fill(this.магазин_ОдеждыDataSet3.Покупки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet2.Покупки". При необходимости она может быть перемещена или удалена.
            this.покупкиTableAdapter2.Fill(this.магазин_ОдеждыDataSet2.Покупки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet.Покупки". При необходимости она может быть перемещена или удалена.
            this.покупкиTableAdapter1.Fill(this.магазин_ОдеждыDataSet.Покупки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet1.Покупки". При необходимости она может быть перемещена или удалена.
            this.покупкиTableAdapter.Fill(this.магазин_ОдеждыDataSet1.Покупки);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }

        private void датаLabel_Click(object sender, EventArgs e)
        {

        }

        private void тип_ОдеждыLabel_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.MovePrevious();
            this.покупкиBindingSource7.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.MoveFirst();
            this.покупкиBindingSource7.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource7.MoveNext();
            this.покупкиBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.MoveLast();
            this.покупкиBindingSource7.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.RemoveCurrent();
            this.покупкиBindingSource7.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.AddNew();
            this.покупкиBindingSource7.AddNew();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ценаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double ant = Convert.ToDouble(ценаTextBox1.Text);
                double bnt = (118 * ant) / 100;
                textBox1.Text = bnt.ToString("0.00"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильное число в поле цены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ценаTextBox1.Focus();
            }
        }

        private void ценаLabel_Click(object sender, EventArgs e)
        {

        }

        private void ценаLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void тип_ОдеждыTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ценаTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}