using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace OverwatchTracker
{
    public static class Utility
    {
        public static int NumberOfIndexes {set; get;}
        private const string _header = "SR\tResult\tDiffer\tCompetitive Points\tDate";

        public static List<Game> Data = new List<Game>();

        public enum CP
        {
            Win = 10,
            Loss = 0,
            Draw = 3
        }

        /// <summary>
        /// Reads data from a file and returns it as a string list
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static List<Game> ReadAllData(string dir)
        {
            if (!File.Exists(dir)) using (StreamWriter sw = File.CreateText(dir)) sw.WriteLine(_header);

            var reference = File.ReadAllLines(dir);

            int i = 0;
            foreach(var v in reference)
            {
                if(i == 0)
                {
                    i++;

                    continue;
                }
                string[] ssize = v.Split(null);
                Data.Add(new Game(i, int.Parse(ssize[0]), char.Parse(ssize[1]), int.Parse(ssize[2]), int.Parse(ssize[3]), DateTime.ParseExact(ssize[4], "yyyy:MM:dd hh:mm::ss tt", CultureInfo.InvariantCulture)));
                i++;
            }
            NumberOfIndexes = Data.Count;
            return Data;
        }

        /// <summary>
        /// Saves a string of data to a file
        /// </summary>
        /// <param name="s"></param>
        public static void SaveDataString(string dir, string s)
        {
            if (!File.Exists(dir)) using (StreamWriter sw = File.CreateText(dir)) sw.WriteLine(s);

            File.AppendAllText(dir, "\n" + s);
        }

        /// <summary>
        /// Inserts a string list into a text box
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="list"></param>
        public static void InsertData(ListBox lb, List<Game> list)
        {
            lb.Items.Add(_header);
            foreach(var v in list)
            {
                lb.Items.Add(v.GameString());
            }
        }

        public static void ReloadData(ListBox lb, List<Game> list)
        {
            foreach(var v in list)
            {
                if (!lb.Items.Contains(v))
                {
                    lb.Items.Add(v.GameString());
                }
            }
        }
    }
}
