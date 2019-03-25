using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassHierarchy
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            
        }
        List<Issue> Issues = new List<Issue>();

        private void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxEdition.Clear();
            textBoxNature.Clear();
            textBoxAudience.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBoxType.SelectedIndex = 0;
            checkBoxIllustr.Checked = false;
            checkBoxOriginality.Checked = false;
            checkBoxPeriodicity.Checked = false;
            checkBoxCatalog.Checked = false;
        }

        //Обновление dataGridView
        private void dataGridAndAllListsUpdate()
        {
            listBoxInfo.Items.Clear();
            dataGridView.Rows.Clear();
            ClearTextBoxes();
            string periodicity = "";
            string originality = "";
            for (int i = 0; i < Issues.Count; i++)
            {
                if (Issues[i].Periodicity)
                    periodicity = "периодично";
                else periodicity = "не периодично";
                if (Issues[i].Category.Originality)
                    originality = "Оригинал";
                else originality = "Переведено";
                dataGridView.Rows.Add(Issues[i].Name, periodicity, 
                    Issues[i].Edition, $"{Issues[i].Category.NatureOfInfo}; " +
                    $"{originality}; {Issues[i].Category.TargetAudience}");
            }        
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            checkBoxIllustr.Visible = false;
            checkBoxCatalog.Visible = false;

            if (comboBoxType.SelectedIndex == 1)
            {
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = "Автор:*";
                label2.Text = "Переплёт:*";
                textBox1.Visible = true;
                textBox2.Visible = true;
                checkBoxIllustr.Visible = true;

                textBox3.Visible = false;
                label3.Visible = false;
                checkBoxCatalog.Visible = false;
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                label1.Text = "№ Номер:*";
                label2.Text = "Тема номера:*";
                label3.Text = "Редакторы:*";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;

                checkBoxIllustr.Visible = false;
                checkBoxCatalog.Visible = false;
            }
            else if (comboBoxType.SelectedIndex == 3)
            {
                label1.Visible = true;
                label1.Text = "Вид издания:*";
                textBox1.Visible = true;

                textBox2.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                checkBoxIllustr.Visible = false;
                checkBoxCatalog.Visible = false;
            }
            else if (comboBoxType.SelectedIndex == 4)
            {
                checkBoxCatalog.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = "Автор:*";
                label2.Text = "Переплёт:*";
                textBox1.Visible = true;
                textBox2.Visible = true;
                checkBoxIllustr.Visible = true;

                label3.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить издание " + 
                    dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].Cells[0].Value 
                    + "?", "Удаление издания", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) 
                    == DialogResult.Yes)
                {
                    Issues.RemoveAt(dataGridView.SelectedCells[0].RowIndex);
                    MessageBox.Show("Издание успешно удалено!");
                }
                else
                    MessageBox.Show("Издание не удалено!");
                dataGridAndAllListsUpdate();
            }
            catch
            {
                MessageBox.Show("Выберите издание!");
            }
        }

        private bool inputtedValues()
        {
            if (textBoxName.Text == "" || textBoxEdition.Text == "" 
                || textBoxNature.Text == "" || textBoxAudience.Text == "")
                return false;
            else
                return true;
        }

        private static Issue getIssueType(string issueType, string name, int edition,
            bool periodicity, Category category, string firstParam, string secondParam,
            string thirdParam, bool isIllustr, bool isCatalog)
        {
            if (issueType.Equals("Книга"))
                return new Book(category, name, edition, periodicity, 
                    firstParam, secondParam, isIllustr);
            else if (issueType.Equals("Не уточнено"))
                return new Issue(category, name, edition, periodicity);
            else if (issueType.Equals("Журнал"))
                return new Journal(category, name, edition, periodicity,
                    Convert.ToInt16(firstParam), secondParam, thirdParam);
            else if (issueType.Equals("Мини-издание"))
                return new Mini_Issue(category, name, edition, periodicity, firstParam);
            else if (issueType.Equals("Брошюра"))
                return new Brochure(category, name, edition, periodicity,
                    firstParam, secondParam, isIllustr, isCatalog);
            else
                throw new Exception(issueType + " не существует в списке изданий!");
        } 

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (inputtedValues())
            {
                Category currCategory;
                currCategory = new Category(textBoxNature.Text, textBoxAudience.Text,
                    checkBoxOriginality.Checked);
                
                Issue issue = getIssueType(comboBoxType.Text.ToString(), textBoxName.Text, 
                    Convert.ToInt16(textBoxEdition.Text), checkBoxPeriodicity.Checked, currCategory,
                    textBox1.Text, textBox2.Text, textBox3.Text, checkBoxIllustr.Checked,
                    checkBoxCatalog.Checked);
                Issues.Add(issue);
                dataGridAndAllListsUpdate();

            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void CRUD_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxEdition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true ||
                e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                return;
            e.Handled = true;
            return;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (inputtedValues())
            {
                Issues[dataGridView.SelectedCells[0].RowIndex].Name = textBoxName.Text;
                Issues[dataGridView.SelectedCells[0].RowIndex].Edition = Convert.ToInt16(textBoxEdition.Text);
                Issues[dataGridView.SelectedCells[0].RowIndex].Periodicity = checkBoxPeriodicity.Checked;
                Issues[dataGridView.SelectedCells[0].RowIndex].Category.NatureOfInfo = textBoxNature.Text;
                Issues[dataGridView.SelectedCells[0].RowIndex].Category.Originality = checkBoxOriginality.Checked;
                Issues[dataGridView.SelectedCells[0].RowIndex].Category.TargetAudience = textBoxAudience.Text;

                comboBoxType.SelectedIndex = 0;
                if (Issues[dataGridView.SelectedCells[0].RowIndex] is Book)
                {
                    comboBoxType.SelectedIndex = 1;
                    Book curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Book;
                    curr.Author = textBox1.Text;
                    curr.Binding = textBox2.Text;
                    curr.IllustratedBookend = checkBoxIllustr.Checked;
                    Issues[dataGridView.SelectedCells[0].RowIndex] = curr;
                }
                else if (Issues[dataGridView.SelectedCells[0].RowIndex] is Journal)
                {
                    comboBoxType.SelectedIndex = 2;
                    Journal curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Journal;
                    curr.SerialNumber = Convert.ToInt16(textBox1.Text);
                    curr.Topic = textBox2.Text;
                    curr.Redactors = textBox3.Text;
                    Issues[dataGridView.SelectedCells[0].RowIndex] = curr;
                }
                else if (Issues[dataGridView.SelectedCells[0].RowIndex] is Mini_Issue)
                {
                    comboBoxType.SelectedIndex = 3;
                    Mini_Issue curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Mini_Issue;
                    curr.Kind = textBox1.Text;
                    Issues[dataGridView.SelectedCells[0].RowIndex] = curr;
                }
                else if (Issues[dataGridView.SelectedCells[0].RowIndex] is Brochure)
                {
                    comboBoxType.SelectedIndex = 4;
                    Brochure curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Brochure;
                    curr.Author = textBox1.Text;
                    curr.Binding = textBox2.Text;
                    curr.IllustratedBookend = checkBoxIllustr.Checked;
                    curr.IsCatalog = checkBoxCatalog.Checked;
                    Issues[dataGridView.SelectedCells[0].RowIndex] = curr;
                }
                dataGridAndAllListsUpdate();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listBoxInfo.Items.Clear();
            FillTextBoxes();
            try
            {
                listBoxInfo.Items.Add($"Название: { Issues[dataGridView.SelectedCells[0].RowIndex].Name}");
                listBoxInfo.Items.Add($"Тираж: { Issues[dataGridView.SelectedCells[0].RowIndex].Edition}");
                if (Issues[dataGridView.SelectedCells[0].RowIndex].Periodicity)
                    listBoxInfo.Items.Add("Периодично");
                else
                    listBoxInfo.Items.Add("Не периодично");
                listBoxInfo.Items.Add($"Категория: { Issues[dataGridView.SelectedCells[0].RowIndex].Category.NatureOfInfo}");
                listBoxInfo.Items.Add($"Цел. аудитория:{ Issues[dataGridView.SelectedCells[0].RowIndex].Category.TargetAudience}");
                if (Issues[dataGridView.SelectedCells[0].RowIndex].Category.Originality)
                    listBoxInfo.Items.Add("Оригинальное");
                else
                    listBoxInfo.Items.Add("Переведено");


                if (Issues[dataGridView.SelectedCells[0].RowIndex] is Book)
                {
                    Book curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Book;
                    listBoxInfo.Items.Add("Тип издания - книга");
                    listBoxInfo.Items.Add($"Автор: { curr.Author}");
                    listBoxInfo.Items.Add($"Переплёт: { curr.Binding}");
                    if (curr.IllustratedBookend)
                        listBoxInfo.Items.Add("Иллюстрированный форзац");
                    else listBoxInfo.Items.Add("Форзац не иллюстрирован");
                }
                else if (Issues[dataGridView.SelectedCells[0].RowIndex] is Journal)
                {
                    Journal curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Journal;
                    listBoxInfo.Items.Add("Тип издания - журнал");
                    listBoxInfo.Items.Add($"Тема: { curr.Topic}");
                    listBoxInfo.Items.Add($"Серийный номер: { curr.SerialNumber}");
                    listBoxInfo.Items.Add($"Редакторы: { curr.Redactors}");
                }
                else if (Issues[dataGridView.SelectedCells[0].RowIndex] is Mini_Issue)
                {
                    Mini_Issue curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Mini_Issue;
                    listBoxInfo.Items.Add("Тип издания - мини-издание");
                    listBoxInfo.Items.Add($"Вид мини-издания: { curr.Kind}");
                }
                else if (Issues[dataGridView.SelectedCells[0].RowIndex] is Brochure)
                {
                    Brochure curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Brochure;
                    listBoxInfo.Items.Add("Тип издания - брошюра");
                    if (curr.IsCatalog)
                        listBoxInfo.Items.Add("Является каталогом");
                    else
                        listBoxInfo.Items.Add("Не вляется каталогом");
                }
                else
                {
                    listBoxInfo.Items.Add("Издание");
                }
            }
            catch
            {
                MessageBox.Show("Выберите издание!");
            }
        }


        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillTextBoxes()
        {
            textBoxName.Text = Issues[dataGridView.SelectedCells[0].RowIndex].Name;
            textBoxEdition.Text = Issues[dataGridView.SelectedCells[0].RowIndex].Edition.ToString();
            checkBoxPeriodicity.Checked = Issues[dataGridView.SelectedCells[0].RowIndex].Periodicity;
            textBoxNature.Text = Issues[dataGridView.SelectedCells[0].RowIndex].Category.NatureOfInfo;
            textBoxAudience.Text = Issues[dataGridView.SelectedCells[0].RowIndex].Category.TargetAudience;
            checkBoxOriginality.Checked = Issues[dataGridView.SelectedCells[0].RowIndex].Category.Originality;

            comboBoxType.SelectedIndex = 0;
            if (Issues[dataGridView.SelectedCells[0].RowIndex] is Book)
            {
                comboBoxType.SelectedIndex = 1;
                Book curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Book;
                textBox1.Text = curr.Author;
                textBox2.Text = curr.Binding;
                checkBoxIllustr.Checked = curr.IllustratedBookend;
            }
            else if (Issues[dataGridView.SelectedCells[0].RowIndex] is Journal)
            {
                comboBoxType.SelectedIndex = 2;
                Journal curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Journal;
                textBox1.Text = curr.SerialNumber.ToString();
                textBox2.Text = curr.Topic;
                textBox3.Text = curr.Redactors;
            }
            else if (Issues[dataGridView.SelectedCells[0].RowIndex] is Mini_Issue)
            {
                comboBoxType.SelectedIndex = 3;
                Mini_Issue curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Mini_Issue;
                textBox1.Text = curr.Kind;
            }
            else if (Issues[dataGridView.SelectedCells[0].RowIndex] is Brochure)
            {
                comboBoxType.SelectedIndex = 4;
                Brochure curr = Issues[dataGridView.SelectedCells[0].RowIndex] as Brochure;
                textBox1.Text = curr.Author;
                textBox2.Text = curr.Binding;
                checkBoxIllustr.Checked = curr.IllustratedBookend;
                checkBoxCatalog.Checked = curr.IsCatalog;
            }
        }
        
    }
}
