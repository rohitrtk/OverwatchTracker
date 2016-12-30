using System;

namespace OverwatchTracker
{
    /// <summary>
    /// This class stores information on each Overwatch game
    /// </summary>
    public class Game
    {
        public int Index { get; }
        public int Sr { get; }
        public char WinLoss { get; }
        public int Difference { get; }
        public int CompetitvePoints { get; }
        public DateTime CurrentDateTime { get; }

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
            return Sr + "\t" + WinLoss + "\t" + Difference + "\t" + CompetitvePoints + "\t" + CurrentDateTime.ToShortDateString();
        }
    }
}
