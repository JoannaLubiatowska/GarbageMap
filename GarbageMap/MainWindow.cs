using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarbageMap
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string latitude = localization_LATTextBox.Text;
            string longitude = localization_LNGTextBox.Text;

            try
            {
                StringBuilder location = new StringBuilder();
                location.Append("http://maps.google.com/maps?q=");

                if (latitude != string.Empty && longitude != string.Empty)
                {
                    location.Append(latitude + "," + longitude);
                }
                webBrowser1.Navigate(location.ToString());
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void notificationDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notificationDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void notificationDataBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.notificationDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.NotificationData' table. You can move, or remove it, as needed.
            this.notificationDataTableAdapter.Fill(this.dataSet.NotificationData);

        }
    }
}
