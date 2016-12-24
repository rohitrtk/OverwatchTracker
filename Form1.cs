using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverwatchTracker
{
    public partial class Form_MainForm : Form
    {
        private string _readDirectory { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Overwatch.txt";
        private string _saveDirectory { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Overwatch.txt";

        public Form_MainForm()
        {
            InitializeComponent();

            textBox_ReadDir.Text = _readDirectory;
            textBox_SaveDir.Text = _saveDirectory;

            var myList = Utility.ReadAllData(_readDirectory);
            Utility.InsertData(listBox_Display, myList);
        }

        private void button_AddData_Click(object sender, EventArgs e)
        {
            var myForm = new EditData(_readDirectory);
            myForm.Show();
        }
    }
}
