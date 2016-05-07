using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProkatAuto
{
    public partial class ProkatAutoForm : Form
    {
        public ProkatAutoForm()
        {
            InitializeComponent();
            DBworker.createDB();
        }

        private void addAutoButton_Click(object sender, EventArgs e)
        {
            new AddAutoForm().ShowDialog();
        }

        private void giveAutoButton_Click(object sender, EventArgs e)
        {
            new GiveAutoForm().ShowDialog();
        }

        private void ProkatAutoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBworker.close();
            Report.closeCon();
        }

        private void getAutoButton_Click(object sender, EventArgs e)
        {
            new GetAutoForm().ShowDialog();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                Report.makePdfReport();
                Process.Start("autoReport.pdf");
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Возникла ошибка при создании отчёта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            new BackupForm().ShowDialog();
        }
    }
}
