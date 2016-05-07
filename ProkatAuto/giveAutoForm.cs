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
    public partial class GiveAutoForm : Form
    {
        Dictionary<int, string> freeAutoDic, clientDic;
        public GiveAutoForm()
        {
            InitializeComponent();
            freeAutoDic = DBworker.getData("AUTO");
            clientDic = DBworker.getData("CLIENT");
            autoComboBox.DataSource = freeAutoDic.Values.ToList();
            clientComboBox.DataSource = clientDic.Values.ToList();
        }

        private void newClientButton_Click(object sender, EventArgs e)
        {
            new AddClientForm().ShowDialog();
            clientDic = DBworker.getData("CLIENT");
            clientComboBox.Text = "";
            clientComboBox.DataSource = clientDic.Values.ToList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (DBworker.getData("AUTO").Count == 0 || DBworker.getData("CLIENT").Count == 0)
                MessageBox.Show("Машина или клиент не выбраны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                DBworker.addProkat(freeAutoDic.FirstOrDefault(x => x.Value.Equals(autoComboBox.SelectedItem)).Key, clientDic.FirstOrDefault(x => x.Value.Equals(clientComboBox.SelectedItem)).Key, DateTime.Now.Ticks / 10000);
                autoComboBox.Text = "";
                clientComboBox.Text = "";
                autoComboBox.DataSource = DBworker.getData("AUTO").Values.ToList();
                clientComboBox.DataSource = DBworker.getData("CLIENT").Values.ToList();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
