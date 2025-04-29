namespace МагазинОдежды
{
    partial class Form2
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
            System.Windows.Forms.Label тип_одеждыLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label странаLabel;
            System.Windows.Forms.Label размерLabel;
            System.Windows.Forms.Label полLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.магазин_ОдеждыDataSet1 = new МагазинОдежды.Магазин_ОдеждыDataSet1();
            this.тип_одеждыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_одеждыTableAdapter = new МагазинОдежды.Магазин_ОдеждыDataSet1TableAdapters.Тип_одеждыTableAdapter();
            this.tableAdapterManager = new МагазинОдежды.Магазин_ОдеждыDataSet1TableAdapters.TableAdapterManager();
            this.тип_одеждыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.тип_одеждыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.тип_одеждыTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.странаTextBox = new System.Windows.Forms.TextBox();
            this.размерTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.типОдеждыТаблицаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблицаTableAdapter = new МагазинОдежды.Магазин_ОдеждыDataSet1TableAdapters.ТаблицаTableAdapter();
            this.типОдеждыТаблицаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.магазин_ОдеждыDataSet = new МагазинОдежды.Магазин_ОдеждыDataSet();
            this.тип_одеждыTableAdapter1 = new МагазинОдежды.Магазин_ОдеждыDataSetTableAdapters.Тип_одеждыTableAdapter();
            this.tableAdapterManager1 = new МагазинОдежды.Магазин_ОдеждыDataSetTableAdapters.TableAdapterManager();
            тип_одеждыLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            странаLabel = new System.Windows.Forms.Label();
            размерLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.магазин_ОдеждыDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_одеждыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_одеждыBindingNavigator)).BeginInit();
            this.тип_одеждыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типОдеждыТаблицаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОдеждыТаблицаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазин_ОдеждыDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // тип_одеждыLabel
            // 
            тип_одеждыLabel.AutoSize = true;
            тип_одеждыLabel.Location = new System.Drawing.Point(250, 118);
            тип_одеждыLabel.Name = "тип_одеждыLabel";
            тип_одеждыLabel.Size = new System.Drawing.Size(88, 16);
            тип_одеждыLabel.TabIndex = 2;
            тип_одеждыLabel.Text = "Тип одежды:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(295, 156);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(43, 16);
            ценаLabel.TabIndex = 4;
            ценаLabel.Text = "Цена:";
            // 
            // странаLabel
            // 
            странаLabel.AutoSize = true;
            странаLabel.Location = new System.Drawing.Point(280, 194);
            странаLabel.Name = "странаLabel";
            странаLabel.Size = new System.Drawing.Size(58, 16);
            странаLabel.TabIndex = 6;
            странаLabel.Text = "Страна:";
            // 
            // размерLabel
            // 
            размерLabel.AutoSize = true;
            размерLabel.Location = new System.Drawing.Point(278, 237);
            размерLabel.Name = "размерLabel";
            размерLabel.Size = new System.Drawing.Size(60, 16);
            размерLabel.TabIndex = 8;
            размерLabel.Text = "Размер:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(302, 279);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(36, 16);
            полLabel.TabIndex = 10;
            полLabel.Text = "Пол:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(172, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Тип одежды\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // магазин_ОдеждыDataSet1
            // 
            this.магазин_ОдеждыDataSet1.DataSetName = "Магазин_ОдеждыDataSet1";
            this.магазин_ОдеждыDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тип_одеждыBindingSource
            // 
            this.тип_одеждыBindingSource.DataMember = "Тип одежды";
            this.тип_одеждыBindingSource.DataSource = this.магазин_ОдеждыDataSet1;
            // 
            // тип_одеждыTableAdapter
            // 
            this.тип_одеждыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = МагазинОдежды.Магазин_ОдеждыDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ПокупкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТаблицаTableAdapter = null;
            this.tableAdapterManager.Тип_одеждыTableAdapter = this.тип_одеждыTableAdapter;
            // 
            // тип_одеждыBindingNavigator
            // 
            this.тип_одеждыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.тип_одеждыBindingNavigator.BindingSource = this.тип_одеждыBindingSource;
            this.тип_одеждыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.тип_одеждыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.тип_одеждыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.тип_одеждыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.тип_одеждыBindingNavigatorSaveItem});
            this.тип_одеждыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.тип_одеждыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.тип_одеждыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.тип_одеждыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.тип_одеждыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.тип_одеждыBindingNavigator.Name = "тип_одеждыBindingNavigator";
            this.тип_одеждыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.тип_одеждыBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.тип_одеждыBindingNavigator.TabIndex = 1;
            this.тип_одеждыBindingNavigator.Text = "bindingNavigator1";
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
            // тип_одеждыBindingNavigatorSaveItem
            // 
            this.тип_одеждыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.тип_одеждыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("тип_одеждыBindingNavigatorSaveItem.Image")));
            this.тип_одеждыBindingNavigatorSaveItem.Name = "тип_одеждыBindingNavigatorSaveItem";
            this.тип_одеждыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.тип_одеждыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.тип_одеждыBindingNavigatorSaveItem.Click += new System.EventHandler(this.тип_одеждыBindingNavigatorSaveItem_Click_1);
            // 
            // тип_одеждыTextBox
            // 
            this.тип_одеждыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тип_одеждыBindingSource, "Тип одежды", true));
            this.тип_одеждыTextBox.Location = new System.Drawing.Point(344, 115);
            this.тип_одеждыTextBox.Name = "тип_одеждыTextBox";
            this.тип_одеждыTextBox.Size = new System.Drawing.Size(100, 22);
            this.тип_одеждыTextBox.TabIndex = 3;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тип_одеждыBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(344, 153);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 22);
            this.ценаTextBox.TabIndex = 5;
            // 
            // странаTextBox
            // 
            this.странаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тип_одеждыBindingSource, "Страна", true));
            this.странаTextBox.Location = new System.Drawing.Point(344, 191);
            this.странаTextBox.Name = "странаTextBox";
            this.странаTextBox.Size = new System.Drawing.Size(100, 22);
            this.странаTextBox.TabIndex = 7;
            // 
            // размерTextBox
            // 
            this.размерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тип_одеждыBindingSource, "Размер", true));
            this.размерTextBox.Location = new System.Drawing.Point(344, 234);
            this.размерTextBox.Name = "размерTextBox";
            this.размерTextBox.Size = new System.Drawing.Size(100, 22);
            this.размерTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(511, 175);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(111, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(413, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 29);
            this.button4.TabIndex = 15;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(413, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 29);
            this.button5.TabIndex = 16;
            this.button5.Text = "Следущая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(511, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 35);
            this.button6.TabIndex = 17;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(125, 112);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 29);
            this.button7.TabIndex = 18;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тип_одеждыBindingSource, "Пол", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.тип_одеждыBindingSource, "Пол", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.тип_одеждыBindingSource, "Пол", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Мужская",
            "Женская"});
            this.comboBox1.Location = new System.Drawing.Point(344, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // типОдеждыТаблицаBindingSource
            // 
            this.типОдеждыТаблицаBindingSource.DataMember = "Тип одеждыТаблица";
            this.типОдеждыТаблицаBindingSource.DataSource = this.тип_одеждыBindingSource;
            // 
            // таблицаTableAdapter
            // 
            this.таблицаTableAdapter.ClearBeforeFill = true;
            // 
            // типОдеждыТаблицаBindingSource1
            // 
            this.типОдеждыТаблицаBindingSource1.DataMember = "Тип одеждыТаблица";
            this.типОдеждыТаблицаBindingSource1.DataSource = this.тип_одеждыBindingSource;
            // 
            // магазин_ОдеждыDataSet
            // 
            this.магазин_ОдеждыDataSet.DataSetName = "Магазин_ОдеждыDataSet";
            this.магазин_ОдеждыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тип_одеждыTableAdapter1
            // 
            this.тип_одеждыTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = МагазинОдежды.Магазин_ОдеждыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.КлиентыTableAdapter = null;
            this.tableAdapterManager1.ПокупкиTableAdapter = null;
            this.tableAdapterManager1.ПоставщикиTableAdapter = null;
            this.tableAdapterManager1.СотрудникиTableAdapter = null;
            this.tableAdapterManager1.ТаблицаTableAdapter = null;
            this.tableAdapterManager1.Тип_одеждыTableAdapter = this.тип_одеждыTableAdapter1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(полLabel);
            this.Controls.Add(размерLabel);
            this.Controls.Add(this.размерTextBox);
            this.Controls.Add(странаLabel);
            this.Controls.Add(this.странаTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(тип_одеждыLabel);
            this.Controls.Add(this.тип_одеждыTextBox);
            this.Controls.Add(this.тип_одеждыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Таблица \"Тип одежды\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.магазин_ОдеждыDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_одеждыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_одеждыBindingNavigator)).EndInit();
            this.тип_одеждыBindingNavigator.ResumeLayout(false);
            this.тип_одеждыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типОдеждыТаблицаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типОдеждыТаблицаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазин_ОдеждыDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Магазин_ОдеждыDataSet1 магазин_ОдеждыDataSet1;
        private System.Windows.Forms.BindingSource тип_одеждыBindingSource;
        private Магазин_ОдеждыDataSet1TableAdapters.Тип_одеждыTableAdapter тип_одеждыTableAdapter;
        private Магазин_ОдеждыDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator тип_одеждыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton тип_одеждыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox тип_одеждыTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox странаTextBox;
        private System.Windows.Forms.TextBox размерTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource типОдеждыТаблицаBindingSource;
        private Магазин_ОдеждыDataSet1TableAdapters.ТаблицаTableAdapter таблицаTableAdapter;
        private System.Windows.Forms.BindingSource типОдеждыТаблицаBindingSource1;
        private Магазин_ОдеждыDataSet магазин_ОдеждыDataSet;
        private Магазин_ОдеждыDataSetTableAdapters.Тип_одеждыTableAdapter тип_одеждыTableAdapter1;
        private Магазин_ОдеждыDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}