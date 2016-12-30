using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchTracker
{
    /// <summary>
    /// This class stores information on each Overwatch game
    /// </summary>
    public class Game
    {
        public int Index;
        public int Sr;
        public char WinLoss;
        public int Difference;
        public int CompetitvePoints;
        public DateTime CurrentDateTime;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="index"></param>
        /// <param name="sr"></param>
        /// <param name="winLoss"></param>
        /// <param name="difference"></param>
        /// <param name="cp"></param>
        /// <param name="dt"></param>
        public Game(int index, int sr, char winLoss, int difference, int cp, DateTime dt)
        {
            Index = index;
            Sr = sr;
            WinLoss = winLoss;
            Difference = difference;
            CompetitvePoints = cp;
            CurrentDateTime = dt;
        }

        /// <summary>
        /// This method return the information of the game as a string
        /// </summary>
        /// <returns></returns>
        public string GameString()
        {
            return Sr + "\t" + WinLoss + "\t" + Difference + "\t" + CompetitvePoints + "\t" + CurrentDateTime;
        }
    }
}
