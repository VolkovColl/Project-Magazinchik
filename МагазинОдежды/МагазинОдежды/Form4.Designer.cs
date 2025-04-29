namespace МагазинОдежды
{
    partial class Form4
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
            System.Windows.Forms.Label поставщикLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label городLabel;
            System.Windows.Forms.Label дополнительноLabel;
            System.Windows.Forms.Label уровеньскидкиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.магазин_ОдеждыDataSet = new МагазинОдежды.Магазин_ОдеждыDataSet();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new МагазинОдежды.Магазин_ОдеждыDataSetTableAdapters.ПоставщикиTableAdapter();
            this.tableAdapterManager = new МагазинОдежды.Магазин_ОдеждыDataSetTableAdapters.TableAdapterManager();
            this.поставщикиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.поставщикиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.поставщикTextBox = new System.Windows.Forms.TextBox();
            this.городTextBox = new System.Windows.Forms.TextBox();
            this.дополнительноTextBox = new System.Windows.Forms.TextBox();
            this.уровеньскидкиTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            поставщикLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            дополнительноLabel = new System.Windows.Forms.Label();
            уровеньскидкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.магазин_ОдеждыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingNavigator)).BeginInit();
            this.поставщикиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // поставщикLabel
            // 
            поставщикLabel.AutoSize = true;
            поставщикLabel.Location = new System.Drawing.Point(66, 226);
            поставщикLabel.Name = "поставщикLabel";
            поставщикLabel.Size = new System.Drawing.Size(82, 16);
            поставщикLabel.TabIndex = 1;
            поставщикLabel.Text = "Поставщик:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(78, 273);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(70, 16);
            телефонLabel.TabIndex = 3;
            телефонLabel.Text = "Телефон:";
            // 
            // городLabel
            // 
            городLabel.AutoSize = true;
            городLabel.Location = new System.Drawing.Point(485, 223);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(49, 16);
            городLabel.TabIndex = 5;
            городLabel.Text = "Город:";
            // 
            // дополнительноLabel
            // 
            дополнительноLabel.AutoSize = true;
            дополнительноLabel.Location = new System.Drawing.Point(60, 392);
            дополнительноLabel.Name = "дополнительноLabel";
            дополнительноLabel.Size = new System.Drawing.Size(113, 16);
            дополнительноLabel.TabIndex = 7;
            дополнительноLabel.Text = "Дополнительно:";
            // 
            // уровеньскидкиLabel
            // 
            уровеньскидкиLabel.AutoSize = true;
            уровеньскидкиLabel.Location = new System.Drawing.Point(470, 395);
            уровеньскидкиLabel.Name = "уровеньскидкиLabel";
            уровеньскидкиLabel.Size = new System.Drawing.Size(111, 16);
            уровеньскидкиLabel.TabIndex = 9;
            уровеньскидкиLabel.Text = "Уровеньскидки:";
            // 
            // магазин_ОдеждыDataSet
            // 
            this.магазин_ОдеждыDataSet.DataSetName = "Магазин_ОдеждыDataSet";
            this.магазин_ОдеждыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.магазин_ОдеждыDataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = МагазинОдежды.Магазин_ОдеждыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.ПокупкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = this.поставщикиTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТаблицаTableAdapter = null;
            this.tableAdapterManager.Тип_одеждыTableAdapter = null;
            // 
            // поставщикиBindingNavigator
            // 
            this.поставщикиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.поставщикиBindingNavigator.BindingSource = this.поставщикиBindingSource;
            this.поставщикиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставщикиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.поставщикиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.поставщикиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поставщикиBindingNavigatorSaveItem});
            this.поставщикиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.поставщикиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.поставщикиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.поставщикиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.поставщикиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.поставщикиBindingNavigator.Name = "поставщикиBindingNavigator";
            this.поставщикиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.поставщикиBindingNavigator.Size = new System.Drawing.Size(813, 31);
            this.поставщикиBindingNavigator.TabIndex = 0;
            this.поставщикиBindingNavigator.Text = "bindingNavigator1";
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
            // поставщикиBindingNavigatorSaveItem
            // 
            this.поставщикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.поставщикиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставщикиBindingNavigatorSaveItem.Image")));
            this.поставщикиBindingNavigatorSaveItem.Name = "поставщикиBindingNavigatorSaveItem";
            this.поставщикиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.поставщикиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.поставщикиBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставщикиBindingNavigatorSaveItem_Click);
            // 
            // поставщикTextBox
            // 
            this.поставщикTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Поставщик", true));
            this.поставщикTextBox.Location = new System.Drawing.Point(154, 223);
            this.поставщикTextBox.Name = "поставщикTextBox";
            this.поставщикTextBox.Size = new System.Drawing.Size(207, 22);
            this.поставщикTextBox.TabIndex = 2;
            // 
            // городTextBox
            // 
            this.городTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Город", true));
            this.городTextBox.Location = new System.Drawing.Point(540, 220);
            this.городTextBox.Name = "городTextBox";
            this.городTextBox.Size = new System.Drawing.Size(147, 22);
            this.городTextBox.TabIndex = 6;
            // 
            // дополнительноTextBox
            // 
            this.дополнительноTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Дополнительно", true));
            this.дополнительноTextBox.Location = new System.Drawing.Point(179, 389);
            this.дополнительноTextBox.Name = "дополнительноTextBox";
            this.дополнительноTextBox.Size = new System.Drawing.Size(182, 22);
            this.дополнительноTextBox.TabIndex = 8;
            // 
            // уровеньскидкиTextBox
            // 
            this.уровеньскидкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Уровеньскидки", true));
            this.уровеньскидкиTextBox.Location = new System.Drawing.Point(587, 392);
            this.уровеньскидкиTextBox.Name = "уровеньскидкиTextBox";
            this.уровеньскидкиTextBox.Size = new System.Drawing.Size(100, 22);
            this.уровеньскидкиTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(317, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 43);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поставщики";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Телефон", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(179, 273);
            this.maskedTextBox1.Mask = "+7 (999) 000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBox1.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(543, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 29);
            this.button4.TabIndex = 39;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(179, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 38;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(532, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 29);
            this.button5.TabIndex = 37;
            this.button5.Text = "Следущая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(179, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 29);
            this.button2.TabIndex = 36;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(677, 39);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(111, 35);
            this.button3.TabIndex = 35;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(560, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 35);
            this.button6.TabIndex = 34;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(25, 39);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 29);
            this.button7.TabIndex = 33;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(уровеньскидкиLabel);
            this.Controls.Add(this.уровеньскидкиTextBox);
            this.Controls.Add(дополнительноLabel);
            this.Controls.Add(this.дополнительноTextBox);
            this.Controls.Add(городLabel);
            this.Controls.Add(this.городTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(поставщикLabel);
            this.Controls.Add(this.поставщикTextBox);
            this.Controls.Add(this.поставщикиBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.магазин_ОдеждыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingNavigator)).EndInit();
            this.поставщикиBindingNavigator.ResumeLayout(false);
            this.поставщикиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Магазин_ОдеждыDataSet магазин_ОдеждыDataSet;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private Магазин_ОдеждыDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private Магазин_ОдеждыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator поставщикиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton поставщикиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox поставщикTextBox;
        private System.Windows.Forms.TextBox городTextBox;
        private System.Windows.Forms.TextBox дополнительноTextBox;
        private System.Windows.Forms.TextBox уровеньскидкиTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}