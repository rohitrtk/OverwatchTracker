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
    public partial class EditData : Form
    {
        private const char Win = 'W';
        private const char Loss = 'L';
        private const char Draw = 'D';

        private string _dir;
        private int _sr;
        private char _winLoss;
        private int _difference;
        private int _competitvePoints;

        public EditData(string dir)
        {
            InitializeComponent();
            _dir = dir;
            _competitvePoints = Utility.Data[Utility.Data.Count - 1].CompetitvePoints;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            _sr = int.Parse(textBox_SR.Text);
            _winLoss = char.Parse(textBox_WL.Text);

            if(_winLoss == Win) _competitvePoints += (int)Utility.CP.Win;
            else if(_winLoss == Loss) _competitvePoints += (int)Utility.CP.Loss;
            else _competitvePoints += (int)Utility.CP.Draw;

            _difference = Math.Abs(Utility.Data[Utility.Data.Count - 1].Sr - _sr);

            var data = _sr + "\t" + _winLoss + "\t" + _difference + "\t" + _competitvePoints;
            Utility.SaveDataString(_dir, data);
        }
    }
}