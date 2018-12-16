using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigKeyComparer
{
    public partial class Form1 : Form
    {
        private ConfigComparer _configComparer;
        public Form1()
        {
            InitializeComponent();
            _configComparer = new ConfigComparer();
        }

        private void oldConfigDialogBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Old Config File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = ".config",
                Filter = "config files (*.config)|*.config",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                oldConfigTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void newConfigDialogBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Old Config File",

                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "config files (*.config)|*.config",
                DefaultExt = ".config",                
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                newCongigTextBox.Text = openFileDialog2.FileName;
            }
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            string oldConfigPath = oldConfigTextBox.Text;
            string newConfigPath = newCongigTextBox.Text;
            if(string.IsNullOrEmpty(oldConfigPath) || string.IsNullOrEmpty(newConfigPath))
            {
                MessageBox.Show("Invalid Data");
            }
            _configComparer.SetOldConfigPath(oldConfigPath);
            _configComparer.SetNewConfigPath(newConfigPath);

            var result = _configComparer.Compare();
            foreach(var config in result)
            {
                dataGridView1.Rows.Add(new string[] { config.Name, config.OldValue, config.NewValue, Enum.GetName(config.Status.GetType(), config.Status)});
            }
        }
    }
}
