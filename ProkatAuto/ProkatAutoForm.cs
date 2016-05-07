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
        }

        private void getAutoButton_Click(object sender, EventArgs e)
        {
            new GetAutoForm().ShowDialog();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                Report.report();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Возникла ошибка при создании отчёта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
