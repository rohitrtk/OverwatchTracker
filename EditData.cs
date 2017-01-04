using System;
using System.Linq;
using System.Windows.Forms;

namespace OverwatchTracker
{
    /// <summary>
    /// Handles the Form_EditData's functionality
    /// </summary>
    public partial class Form_EditData : Form
    {
        private const char Win = 'W';
        private const char Loss = 'L';
        private const char Draw = 'D';

        private bool _empty = false;
        private ListBox _lb;

        private string _dir;
        private int _sr;
        private char _winLoss;
        private int _difference;
        private int _competitvePoints;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="lb"></param>
        public Form_EditData(string dir, ListBox lb)
        {
            InitializeComponent();
            _lb = lb;
            _dir = dir;
        }
        
        /// <summary>
        /// This method is called when the Confirm button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Confirm_Click(object sender, EventArgs e)
        {
            // If the list of games is empty... Set _empty to true or false
            _empty = !Utility.Data.Any();

            _sr = int.Parse(textBox_SR.Text);

            if (!string.IsNullOrEmpty(textBox_WL.Text)) _winLoss = char.Parse(textBox_WL.Text.ToUpper());
            else _winLoss = 'e';

            // If the file is not a new file...
            if (!_empty)
            {
                // Read from game list
                _competitvePoints = Utility.Data[Utility.Data.Count - 1].CompetitvePoints;
                _difference = Math.Abs(Utility.Data[Utility.Data.Count - 1].Sr - _sr);
            }
            // Else...
            else
            {
                // Default 0
                _competitvePoints = 0;
                _difference = 0;
            }

            // This basically lets the user input their "first" game using the tracker
            // as when they start using the tracker, their competitive points might be higher
            // than 0
            if(string.IsNullOrWhiteSpace(textBox_CompPoints.Text))
            {
                if(string.IsNullOrWhiteSpace(textBox_WL.Text))
                {
                    if (Utility.Data[Utility.Data.Count - 1].Sr - _sr < 0) _winLoss = Win;
                    else if (Utility.Data[Utility.Data.Count - 1].Sr - _sr > 0) _winLoss = Loss;
                    else _winLoss = Draw;
                }
                
                if (_winLoss == Win) _competitvePoints += (int)Utility.CP.Win;
                else if (_winLoss == Loss) _competitvePoints += (int)Utility.CP.Loss;
                else _competitvePoints += (int)Utility.CP.Draw;
            }
            else
            {
                _competitvePoints = int.Parse(textBox_CompPoints.Text);
            }
                   
            // Data to be displayed on .txt file and in application
            var data = _sr + "\t" + _winLoss + "\t" + _difference + "\t" + _competitvePoints + "\t" + DateTime.Today.ToShortDateString();

            // Save the data
            Utility.SaveDataString(_dir, data);

            // Reload the data so it can be added into the application
            Utility.ReloadData(_dir, _lb, Utility.Data);

            // Clears all textboxes on this form
            ClearTextBoxes();
        }

        /// <summary>
        /// This method is called when textboxes in the EditData form need to be cleared
        /// </summary>
        private void ClearTextBoxes()
        {
            textBox_CompPoints.Clear();
            textBox_SR.Clear();
            textBox_WL.Clear();
        }
    }
}