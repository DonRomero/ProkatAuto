using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProkatAuto
{
    public partial class AddAutoForm : Form
    {
        public AddAutoForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (markTextBox.TextLength == 0 || colorTextBox.TextLength == 0 || yearTextBox.TextLength == 0 || typeTextBox.TextLength == 0)
            {
                MessageBox.Show("Необходимо заполнить все поля формы!", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Convert.ToInt32(yearTextBox.Text) < 1900 || Convert.ToInt32(yearTextBox.Text) > DateTime.Now.Year)
                    MessageBox.Show("Неверно указан год!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DBworker.addAuto(markTextBox.Text, Convert.ToInt32(yearTextBox.Text), colorTextBox.Text, typeTextBox.Text);
                    markTextBox.Clear();
                    yearTextBox.Clear();
                    colorTextBox.Clear();
                    typeTextBox.Clear();
                }
            }
        }

        private void yearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
