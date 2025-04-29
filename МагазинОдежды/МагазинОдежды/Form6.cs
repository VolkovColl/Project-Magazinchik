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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_ОдеждыDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet.Покупки". При необходимости она может быть перемещена или удалена.
            this.покупкиTableAdapter.Fill(this.магазин_ОдеждыDataSet.Покупки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_ОдеждыDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.магазин_ОдеждыDataSet.Клиенты);

        }

        private void датаDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void датаLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < покупкиDataGridView.ColumnCount - 1; i++)
            {
                for (j = 0; j < покупкиDataGridView.RowCount - 1; j++)
                {
                    покупкиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    покупкиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < покупкиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < покупкиDataGridView.RowCount; j++)
                {
                    var value = покупкиDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();

                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            покупкиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            покупкиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.Filter = $"Дата = #{comboBox1.Text}#";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.Filter = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex) { 
         case 0:
                Col = dataGridViewTextBoxColumn1;
                break;
            case 1:
                Col = dataGridViewTextBoxColumn2;
                break;
            case 2:
                Col = dataGridViewTextBoxColumn3;
                break;
            case 3:
                Col = dataGridViewTextBoxColumn4;
                break;
            case 4:
                Col = dataGridViewTextBoxColumn5;
                break;
            }
            if (Col != null)
            {
                if (radioButton1.Checked)
                {
                    покупкиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
                }
                else if (radioButton2.Checked)
                {
                    покупкиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
                }
                else
                {
                    MessageBox.Show("Выберите направление сортировки.");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
