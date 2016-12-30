using System;
using System.Windows.Forms;

namespace OverwatchTracker
{
    /// <summary>
    /// Handles the Form_MainForm's functionality
    /// </summary>
    public partial class Form_MainForm : Form
    {
        private string _readDirectory;
        private string _saveDirectory;

        /// <summary>
        /// Constructor
        /// </summary>
        public Form_MainForm()
        {

            if(Properties.Settings.Default.FirstLaunch)
            {
                _readDirectory = Utility.DefaultReadDirectory;
                _saveDirectory = Utility.DefaultSaveDirectory;
                Properties.Settings.Default.FirstLaunch = false;
                Properties.Settings.Default.ReadDirectory = Utility.DefaultReadDirectory.ToString();
                Properties.Settings.Default.SaveDirectory = Utility.DefaultSaveDirectory.ToString();
            }
            else
            {
                _readDirectory = Properties.Settings.Default.ReadDirectory;
                _saveDirectory = Properties.Settings.Default.SaveDirectory;
            }

            textBox_SaveDir.Text = _saveDirectory;
            textBox_ReadDir.Text = _readDirectory;

            // Read all data from file
            var myList = Utility.ReadAllData(_readDirectory);

            // Insert that data into a list box
            Utility.InsertData(listBox_Display, myList);

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Called when Add Data button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddData_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form_EditData
            var myForm = new Form_EditData(_readDirectory, listBox_Display);

            // Show the form
            myForm.Show();
        }

        private void textBox_ReadDir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ReadDirectory = textBox_ReadDir.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox_SaveDir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveDirectory = textBox_SaveDir.Text;
            Properties.Settings.Default.Save();
        }
    }
}
