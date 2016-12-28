using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchTracker
{
    public class Game
    {
        public int Index;
        public int Sr;
        public char WinLoss;
        public int Difference;
        public int CompetitvePoints;
        public DateTime CurrentDateTime;

        public Game(int index, int sr, char winLoss, int difference, int cp, DateTime dt)
        {
            Index = index;
            Sr = sr;
            WinLoss = winLoss;
            Difference = difference;
            CompetitvePoints = cp;
            CurrentDateTime = dt;
        }

        public string GameString()
        {
            return Sr + "\t" + WinLoss + "\t" + Difference + "\t" + CompetitvePoints + "\t" + CurrentDateTime;
        }
    }
}
