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
    public partial class GetAutoForm : Form
    {
        Dictionary<int, string> autoDic;
        public GetAutoForm()
        {
            InitializeComponent();
            autoDic = DBworker.getData("PROKAT");
            prokatComboBox.DataSource = autoDic.Values.ToList();
            prokatComboBox_SelectedIndexChanged(null, null);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DBworker.updateProkat(autoDic.FirstOrDefault(x => x.Value.Equals(prokatComboBox.SelectedItem)).Key, DateTime.Now.Ticks / 10000);
            prokatComboBox.Text = "";
            prokatComboBox.DataSource = DBworker.getData("PROKAT").Values.ToList();
            prokatComboBox_SelectedIndexChanged(null, null);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prokatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] prokatData = DBworker.getProkatInfo(autoDic.FirstOrDefault(x => x.Value.Equals(prokatComboBox.SelectedItem)).Key);
            dateTextBox.Text = new DateTime(Convert.ToInt64(prokatData[0]) * 10000).ToString();
            clientTextBox.Text = prokatData[1];
            autoTextBox.Text = prokatData[2];
        }
    }
}
