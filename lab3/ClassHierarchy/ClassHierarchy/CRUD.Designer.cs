namespace ClassHierarchy
{
    partial class CRUD
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сolumnPeriodicity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colomnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelEdition = new System.Windows.Forms.Label();
            this.textBoxEdition = new System.Windows.Forms.TextBox();
            this.labelNature = new System.Windows.Forms.Label();
            this.textBoxNature = new System.Windows.Forms.TextBox();
            this.labelAudience = new System.Windows.Forms.Label();
            this.textBoxAudience = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxPeriodicity = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxIllustr = new System.Windows.Forms.CheckBox();
            this.checkBoxOriginality = new System.Windows.Forms.CheckBox();
            this.checkBoxCatalog = new System.Windows.Forms.CheckBox();
            this.cbSerialize = new System.Windows.Forms.ComboBox();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.сolumnPeriodicity,
            this.columnEdition,
            this.colomnCategory});
            this.dataGridView.Location = new System.Drawing.Point(12, 246);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(848, 248);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // columnName
            // 
            this.columnName.Frozen = true;
            this.columnName.HeaderText = "Название";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Width = 150;
            // 
            // сolumnPeriodicity
            // 
            this.сolumnPeriodicity.Frozen = true;
            this.сolumnPeriodicity.HeaderText = "Периодичность";
            this.сolumnPeriodicity.Name = "сolumnPeriodicity";
            this.сolumnPeriodicity.ReadOnly = true;
            this.сolumnPeriodicity.Width = 130;
            // 
            // columnEdition
            // 
            this.columnEdition.Frozen = true;
            this.columnEdition.HeaderText = "Тираж";
            this.columnEdition.Name = "columnEdition";
            this.columnEdition.ReadOnly = true;
            // 
            // colomnCategory
            // 
            this.colomnCategory.Frozen = true;
            this.colomnCategory.HeaderText = "Категория";
            this.colomnCategory.Name = "colomnCategory";
            this.colomnCategory.ReadOnly = true;
            this.colomnCategory.Width = 250;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(875, 25);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(122, 53);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Добавить";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(875, 84);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 53);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(875, 143);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(122, 53);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Редактировать";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(866, 250);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(211, 244);
            this.listBoxInfo.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Название:*";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(143, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Location = new System.Drawing.Point(12, 79);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(59, 17);
            this.labelEdition.TabIndex = 12;
            this.labelEdition.Text = "Тираж:*";
            // 
            // textBoxEdition
            // 
            this.textBoxEdition.Location = new System.Drawing.Point(12, 99);
            this.textBoxEdition.Name = "textBoxEdition";
            this.textBoxEdition.Size = new System.Drawing.Size(143, 22);
            this.textBoxEdition.TabIndex = 11;
            this.textBoxEdition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdition_KeyPress);
            // 
            // labelNature
            // 
            this.labelNature.AutoSize = true;
            this.labelNature.Location = new System.Drawing.Point(209, 25);
            this.labelNature.Name = "labelNature";
            this.labelNature.Size = new System.Drawing.Size(143, 17);
            this.labelNature.TabIndex = 14;
            this.labelNature.Text = "Хар-р информации:*";
            // 
            // textBoxNature
            // 
            this.textBoxNature.Location = new System.Drawing.Point(209, 45);
            this.textBoxNature.Name = "textBoxNature";
            this.textBoxNature.Size = new System.Drawing.Size(143, 22);
            this.textBoxNature.TabIndex = 13;
            // 
            // labelAudience
            // 
            this.labelAudience.AutoSize = true;
            this.labelAudience.Location = new System.Drawing.Point(209, 84);
            this.labelAudience.Name = "labelAudience";
            this.labelAudience.Size = new System.Drawing.Size(150, 17);
            this.labelAudience.TabIndex = 16;
            this.labelAudience.Text = "Целевая Аудитория:*";
            // 
            // textBoxAudience
            // 
            this.textBoxAudience.Location = new System.Drawing.Point(209, 104);
            this.textBoxAudience.Name = "textBoxAudience";
            this.textBoxAudience.Size = new System.Drawing.Size(143, 22);
            this.textBoxAudience.TabIndex = 15;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(433, 25);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(96, 17);
            this.labelType.TabIndex = 19;
            this.labelType.Text = "Тип издания:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteCustomSource.AddRange(new string[] {
            "Не уточнено",
            "Книга",
            "Журнал",
            "Мини-издание",
            "Брошюра"});
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Не уточнено",
            "Книга",
            "Журнал",
            "Мини-издание",
            "Брошюра"});
            this.comboBoxType.Location = new System.Drawing.Point(436, 45);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(143, 24);
            this.comboBoxType.TabIndex = 20;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // checkBoxPeriodicity
            // 
            this.checkBoxPeriodicity.AutoSize = true;
            this.checkBoxPeriodicity.Location = new System.Drawing.Point(15, 143);
            this.checkBoxPeriodicity.Name = "checkBoxPeriodicity";
            this.checkBoxPeriodicity.Size = new System.Drawing.Size(138, 21);
            this.checkBoxPeriodicity.TabIndex = 21;
            this.checkBoxPeriodicity.Text = "Периодичность*";
            this.checkBoxPeriodicity.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Автор:*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(639, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Переплёт:*";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(639, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 22);
            this.textBox2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Редактор:*";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(639, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 22);
            this.textBox3.TabIndex = 26;
            // 
            // checkBoxIllustr
            // 
            this.checkBoxIllustr.AutoSize = true;
            this.checkBoxIllustr.Location = new System.Drawing.Point(404, 104);
            this.checkBoxIllustr.Name = "checkBoxIllustr";
            this.checkBoxIllustr.Size = new System.Drawing.Size(215, 21);
            this.checkBoxIllustr.TabIndex = 28;
            this.checkBoxIllustr.Text = "Иллюстрированный форзац";
            this.checkBoxIllustr.UseVisualStyleBackColor = true;
            // 
            // checkBoxOriginality
            // 
            this.checkBoxOriginality.AutoSize = true;
            this.checkBoxOriginality.Location = new System.Drawing.Point(209, 143);
            this.checkBoxOriginality.Name = "checkBoxOriginality";
            this.checkBoxOriginality.Size = new System.Drawing.Size(143, 21);
            this.checkBoxOriginality.TabIndex = 29;
            this.checkBoxOriginality.Text = "Оригинальность*";
            this.checkBoxOriginality.UseVisualStyleBackColor = true;
            // 
            // checkBoxCatalog
            // 
            this.checkBoxCatalog.AutoSize = true;
            this.checkBoxCatalog.Location = new System.Drawing.Point(461, 131);
            this.checkBoxCatalog.Name = "checkBoxCatalog";
            this.checkBoxCatalog.Size = new System.Drawing.Size(91, 21);
            this.checkBoxCatalog.TabIndex = 30;
            this.checkBoxCatalog.Text = "Каталог?";
            this.checkBoxCatalog.UseVisualStyleBackColor = true;
            // 
            // cbSerialize
            // 
            this.cbSerialize.FormattingEnabled = true;
            this.cbSerialize.Items.AddRange(new object[] {
            "бинарная",
            "XML",
            "произвольная"});
            this.cbSerialize.Location = new System.Drawing.Point(15, 207);
            this.cbSerialize.Name = "cbSerialize";
            this.cbSerialize.Size = new System.Drawing.Size(138, 24);
            this.cbSerialize.TabIndex = 31;
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(212, 203);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(147, 31);
            this.buttonSerialize.TabIndex = 32;
            this.buttonSerialize.Text = "Сериализовать";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(404, 202);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(163, 32);
            this.buttonDeserialize.TabIndex = 33;
            this.buttonDeserialize.Text = "Загрузить из файла";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Сериализация:";
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.cbSerialize);
            this.Controls.Add(this.checkBoxCatalog);
            this.Controls.Add(this.checkBoxOriginality);
            this.Controls.Add(this.checkBoxIllustr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxPeriodicity);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelAudience);
            this.Controls.Add(this.textBoxAudience);
            this.Controls.Add(this.labelNature);
            this.Controls.Add(this.textBoxNature);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.textBoxEdition);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataGridView);
            this.Name = "CRUD";
            this.Text = "Печатные издания";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CRUD_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelEdition;
        private System.Windows.Forms.TextBox textBoxEdition;
        private System.Windows.Forms.Label labelNature;
        private System.Windows.Forms.TextBox textBoxNature;
        private System.Windows.Forms.Label labelAudience;
        private System.Windows.Forms.TextBox textBoxAudience;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.CheckBox checkBoxPeriodicity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBoxIllustr;
        private System.Windows.Forms.CheckBox checkBoxOriginality;
        private System.Windows.Forms.CheckBox checkBoxCatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn сolumnPeriodicity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colomnCategory;
        private System.Windows.Forms.ComboBox cbSerialize;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.Label label4;
    }
}