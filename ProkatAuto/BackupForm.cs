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
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
            DataTable[] arr = Report.makeXMLBackup();
            autoGridView.DataSource = arr[0];
            clientGridView.DataSource = arr[1];
            prokatGridView.DataSource = arr[2];
            dataPanel.Controls.Add(autoGridView);
            dataPanel.Controls.Add(clientGridView);
            dataPanel.Controls.Add(prokatGridView);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Report.saveXmlBackup();
                MessageBox.Show("База данных успешно сохранена.", "Сохранено");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Возникла ошибка при сохранении базы данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
