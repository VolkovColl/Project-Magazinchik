namespace МагазинОдежды
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label промокартаLabel;
            System.Windows.Forms.Label городLabel;
            System.Windows.Forms.Label владелецLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.магазин_ОдеждыDataSet = new МагазинОдежды.Магазин_ОдеждыDataSet();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new МагазинОдежды.Магазин_ОдеждыDataSetTableAdapters.КлиентыTableAdapter();
            this.tableAdapterManager = new МагазинОдежды.Магазин_ОдеждыDataSetTableAdapters.TableAdapterManager();
            this.клиентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.клиентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.промокартаTextBox = new System.Windows.Forms.TextBox();
            this.городTextBox = new System.Windows.Forms.TextBox();
            this.владелецTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            адресLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            промокартаLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            владелецLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.магазин_ОдеждыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingNavigator)).BeginInit();
            this.клиентыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(507, 301);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(50, 16);
            адресLabel.TabIndex = 1;
            адресLabel.Text = "Адрес:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(12, 356);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(122, 16);
            номер_телефонаLabel.TabIndex = 3;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // промокартаLabel
            // 
            промокартаLabel.AutoSize = true;
            промокартаLabel.Location = new System.Drawing.Point(43, 298);
            промокартаLabel.Name = "промокартаLabel";
            промокартаLabel.Size = new System.Drawing.Size(91, 16);
            промокартаLabel.TabIndex = 5;
            промокартаLabel.Text = "Промокарта:";
            // 
            // городLabel
            // 
            городLabel.AutoSize = true;
            городLabel.Location = new System.Drawing.Point(508, 353);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(49, 16);
            городLabel.TabIndex = 7;
            городLabel.Text = "Город:";
            // 
            // владелецLabel
            // 
            владелецLabel.AutoSize = true;
            владелецLabel.Location = new System.Drawing.Point(266, 242);
            владелецLabel.Name = "владелецLabel";
            владелецLabel.Size = new System.Drawing.Size(75, 16);
            владелецLabel.TabIndex = 9;
            владелецLabel.Text = "Владелец:";
            // 
            // магазин_ОдеждыDataSet
            // 
            this.магазин_ОдеждыDataSet.DataSetName = "Магазин_ОдеждыDataSet";
            this.магазин_ОдеждыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.магазин_ОдеждыDataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = МагазинОдежды.Магазин_ОдеждыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.ПокупкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТаблицаTableAdapter = null;
            this.tableAdapterManager.Тип_одеждыTableAdapter = null;
            // 
            // клиентыBindingNavigator
            // 
            this.клиентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.клиентыBindingNavigator.BindingSource = this.клиентыBindingSource;
            this.клиентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.клиентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.клиентыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.клиентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.клиентыBindingNavigatorSaveItem});
            this.клиентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клиентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.клиентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.клиентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.клиентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.клиентыBindingNavigator.Name = "клиентыBindingNavigator";
            this.клиентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.клиентыBindingNavigator.Size = new System.Drawing.Size(801, 31);
            this.клиентыBindingNavigator.TabIndex = 0;
            this.клиентыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // клиентыBindingNavigatorSaveItem
            // 
            this.клиентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клиентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клиентыBindingNavigatorSaveItem.Image")));
            this.клиентыBindingNavigatorSaveItem.Name = "клиентыBindingNavigatorSaveItem";
            this.клиентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.клиентыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клиентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.клиентыBindingNavigatorSaveItem_Click);
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(563, 298);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(178, 22);
            this.адресTextBox.TabIndex = 2;
            // 
            // промокартаTextBox
            // 
            this.промокартаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Промокарта", true));
            this.промокартаTextBox.Location = new System.Drawing.Point(140, 295);
            this.промокартаTextBox.Name = "промокартаTextBox";
            this.промокартаTextBox.Size = new System.Drawing.Size(178, 22);
            this.промокартаTextBox.TabIndex = 6;
            this.промокартаTextBox.TextChanged += new System.EventHandler(this.промокартаTextBox_TextChanged);
            // 
            // городTextBox
            // 
            this.городTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Город", true));
            this.городTextBox.Location = new System.Drawing.Point(563, 350);
            this.городTextBox.Name = "городTextBox";
            this.городTextBox.Size = new System.Drawing.Size(178, 22);
            this.городTextBox.TabIndex = 8;
            // 
            // владелецTextBox
            // 
            this.владелецTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Владелец", true));
            this.владелецTextBox.Location = new System.Drawing.Point(347, 239);
            this.владелецTextBox.Name = "владелецTextBox";
            this.владелецTextBox.Size = new System.Drawing.Size(166, 22);
            this.владелецTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(342, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Клиенты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Номер телефона", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(138, 356);
            this.maskedTextBox1.Mask = "+7 (999) 000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(15, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 29);
            this.button7.TabIndex = 19;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(225, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 35);
            this.button6.TabIndex = 20;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(494, 106);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(111, 35);
            this.button3.TabIndex = 21;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(130, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 29);
            this.button2.TabIndex = 22;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(552, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 29);
            this.button5.TabIndex = 23;
            this.button5.Text = "Следущая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(130, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(563, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 29);
            this.button4.TabIndex = 25;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(владелецLabel);
            this.Controls.Add(this.владелецTextBox);
            this.Controls.Add(городLabel);
            this.Controls.Add(this.городTextBox);
            this.Controls.Add(промокартаLabel);
            this.Controls.Add(this.промокартаTextBox);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(this.клиентыBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.магазин_ОдеждыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingNavigator)).EndInit();
            this.клиентыBindingNavigator.ResumeLayout(false);
            this.клиентыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Магазин_ОдеждыDataSet магазин_ОдеждыDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private Магазин_ОдеждыDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private Магазин_ОдеждыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клиентыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton клиентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox промокартаTextBox;
        private System.Windows.Forms.TextBox городTextBox;
        private System.Windows.Forms.TextBox владелецTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}