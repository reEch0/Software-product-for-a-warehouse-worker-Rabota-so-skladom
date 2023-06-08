namespace WindowsFormsApp1
{
    partial class ZakazTovara
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
            System.Windows.Forms.Label tovarIDLabel;
            System.Windows.Forms.Label nazvanieLabel;
            System.Windows.Forms.Label opisanieLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label vidLabel;
            System.Windows.Forms.Label kolVo_tovaraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZakazTovara));
            this.tovarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уПDataSet = new WindowsFormsApp1.УПDataSet();
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
            this.tovarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tovarIDTextBox = new System.Windows.Forms.TextBox();
            this.nazvanieTextBox = new System.Windows.Forms.TextBox();
            this.opisanieTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.vidTextBox = new System.Windows.Forms.TextBox();
            this.kolVo_tovaraTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tovarTableAdapter = new WindowsFormsApp1.УПDataSetTableAdapters.TovarTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.УПDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            tovarIDLabel = new System.Windows.Forms.Label();
            nazvanieLabel = new System.Windows.Forms.Label();
            opisanieLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            vidLabel = new System.Windows.Forms.Label();
            kolVo_tovaraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingNavigator)).BeginInit();
            this.tovarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уПDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tovarIDLabel
            // 
            tovarIDLabel.AutoSize = true;
            tovarIDLabel.Location = new System.Drawing.Point(119, 71);
            tovarIDLabel.Name = "tovarIDLabel";
            tovarIDLabel.Size = new System.Drawing.Size(21, 13);
            tovarIDLabel.TabIndex = 1;
            tovarIDLabel.Text = "ID:";
            // 
            // nazvanieLabel
            // 
            nazvanieLabel.AutoSize = true;
            nazvanieLabel.Location = new System.Drawing.Point(81, 115);
            nazvanieLabel.Name = "nazvanieLabel";
            nazvanieLabel.Size = new System.Drawing.Size(60, 13);
            nazvanieLabel.TabIndex = 3;
            nazvanieLabel.Text = "Название:";
            // 
            // opisanieLabel
            // 
            opisanieLabel.AutoSize = true;
            opisanieLabel.Location = new System.Drawing.Point(80, 154);
            opisanieLabel.Name = "opisanieLabel";
            opisanieLabel.Size = new System.Drawing.Size(60, 13);
            opisanieLabel.TabIndex = 5;
            opisanieLabel.Text = "Описание:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(104, 239);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(36, 13);
            cenaLabel.TabIndex = 7;
            cenaLabel.Text = "Цена:";
            // 
            // vidLabel
            // 
            vidLabel.AutoSize = true;
            vidLabel.Location = new System.Drawing.Point(111, 196);
            vidLabel.Name = "vidLabel";
            vidLabel.Size = new System.Drawing.Size(29, 13);
            vidLabel.TabIndex = 9;
            vidLabel.Text = "Вид:";
            // 
            // kolVo_tovaraLabel
            // 
            kolVo_tovaraLabel.AutoSize = true;
            kolVo_tovaraLabel.Location = new System.Drawing.Point(58, 282);
            kolVo_tovaraLabel.Name = "kolVo_tovaraLabel";
            kolVo_tovaraLabel.Size = new System.Drawing.Size(82, 13);
            kolVo_tovaraLabel.TabIndex = 11;
            kolVo_tovaraLabel.Text = "Кол-во товара:";
            // 
            // tovarBindingNavigator
            // 
            this.tovarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tovarBindingNavigator.BindingSource = this.tovarBindingSource;
            this.tovarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tovarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tovarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tovarBindingNavigatorSaveItem});
            this.tovarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tovarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tovarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tovarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tovarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tovarBindingNavigator.Name = "tovarBindingNavigator";
            this.tovarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tovarBindingNavigator.Size = new System.Drawing.Size(387, 25);
            this.tovarBindingNavigator.TabIndex = 0;
            this.tovarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.уПDataSet;
            // 
            // уПDataSet
            // 
            this.уПDataSet.DataSetName = "УПDataSet";
            this.уПDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tovarBindingNavigatorSaveItem
            // 
            this.tovarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tovarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tovarBindingNavigatorSaveItem.Image")));
            this.tovarBindingNavigatorSaveItem.Name = "tovarBindingNavigatorSaveItem";
            this.tovarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tovarBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tovarBindingNavigatorSaveItem.Click += new System.EventHandler(this.tovarBindingNavigatorSaveItem_Click);
            // 
            // tovarIDTextBox
            // 
            this.tovarIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "TovarID", true));
            this.tovarIDTextBox.Location = new System.Drawing.Point(146, 68);
            this.tovarIDTextBox.Name = "tovarIDTextBox";
            this.tovarIDTextBox.Size = new System.Drawing.Size(151, 20);
            this.tovarIDTextBox.TabIndex = 2;
            // 
            // nazvanieTextBox
            // 
            this.nazvanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Nazvanie", true));
            this.nazvanieTextBox.Location = new System.Drawing.Point(147, 112);
            this.nazvanieTextBox.Name = "nazvanieTextBox";
            this.nazvanieTextBox.Size = new System.Drawing.Size(150, 20);
            this.nazvanieTextBox.TabIndex = 4;
            // 
            // opisanieTextBox
            // 
            this.opisanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Opisanie", true));
            this.opisanieTextBox.Location = new System.Drawing.Point(146, 151);
            this.opisanieTextBox.Name = "opisanieTextBox";
            this.opisanieTextBox.Size = new System.Drawing.Size(151, 20);
            this.opisanieTextBox.TabIndex = 6;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(146, 236);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(151, 20);
            this.cenaTextBox.TabIndex = 8;
            // 
            // vidTextBox
            // 
            this.vidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "Vid", true));
            this.vidTextBox.Location = new System.Drawing.Point(146, 193);
            this.vidTextBox.Name = "vidTextBox";
            this.vidTextBox.Size = new System.Drawing.Size(151, 20);
            this.vidTextBox.TabIndex = 10;
            // 
            // kolVo_tovaraTextBox
            // 
            this.kolVo_tovaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource, "KolVo_tovara", true));
            this.kolVo_tovaraTextBox.Location = new System.Drawing.Point(146, 279);
            this.kolVo_tovaraTextBox.Name = "kolVo_tovaraTextBox";
            this.kolVo_tovaraTextBox.Size = new System.Drawing.Size(151, 20);
            this.kolVo_tovaraTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Отправить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlientTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = this.tovarTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.УПDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZakazTableAdapter = null;
            this.tableAdapterManager.ZakazTovarovTableAdapter = null;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Добавить новый товар";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ZakazTovara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(kolVo_tovaraLabel);
            this.Controls.Add(this.kolVo_tovaraTextBox);
            this.Controls.Add(vidLabel);
            this.Controls.Add(this.vidTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(opisanieLabel);
            this.Controls.Add(this.opisanieTextBox);
            this.Controls.Add(nazvanieLabel);
            this.Controls.Add(this.nazvanieTextBox);
            this.Controls.Add(tovarIDLabel);
            this.Controls.Add(this.tovarIDTextBox);
            this.Controls.Add(this.tovarBindingNavigator);
            this.Name = "ZakazTovara";
            this.Text = "ZakazTovara";
            this.Load += new System.EventHandler(this.ZakazTovara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingNavigator)).EndInit();
            this.tovarBindingNavigator.ResumeLayout(false);
            this.tovarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уПDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private УПDataSet уПDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private УПDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private УПDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tovarBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tovarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tovarIDTextBox;
        private System.Windows.Forms.TextBox nazvanieTextBox;
        private System.Windows.Forms.TextBox opisanieTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox vidTextBox;
        private System.Windows.Forms.TextBox kolVo_tovaraTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}