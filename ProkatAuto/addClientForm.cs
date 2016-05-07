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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.TextLength == 0 || name2TextBox.TextLength == 0 || surnameTextBox.TextLength == 0 || yearTextBox.TextLength == 0)
            {
                MessageBox.Show("Необходимо заполнить все поля формы!", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Convert.ToInt32(yearTextBox.Text) < 1900 || Convert.ToInt32(yearTextBox.Text) > DateTime.Now.Year)
                    MessageBox.Show("Неверно указан год!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DBworker.addClient(surnameTextBox.Text + " " + nameTextBox.Text + " " + name2TextBox.Text, Convert.ToInt32(yearTextBox.Text));
                    nameTextBox.Clear();
                    surnameTextBox.Clear();
                    name2TextBox.Clear();
                    yearTextBox.Clear();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
