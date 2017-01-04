using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace OverwatchTracker
{
    /// <summary>
    /// This class is a Utility class, used for referencing constants and useful methods
    /// </summary>
    public static class Utility
    {
        // The string to be placed into text files and the form litbox
        private const string _header = "SR\tResult\tDiffer\tCP\tDate";

        // The default read directory to read data from
        public static string DefaultReadDirectory { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Overwatch.txt";

        // The default save directory to save data to
        public static string DefaultSaveDirectory { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Overwatch.txt";

        // List of games from txt file
        public static List<Game> Data = new List<Game>();

        // Competitive points to be added depending on Win, Loss or Draw
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
            // If file doesn't exist, create it and add the header to it
            if (!File.Exists(dir)) 
            {
                using (StreamWriter sw = File.CreateText(dir))
                {
                    sw.Write(_header);
                    sw.Dispose();
                }
            }
            // Temp variable to read all the data from the file
            var reference = File.ReadAllLines(dir);

            // Counter variable
            var i = 0;

            // Foreach variable in temp variable...
            foreach(var v in reference)
            {
                // If counter is 0, restart the loop because that index is the header string
                if(i == 0)
                {
                    i++;

                    continue;
                }
                // Split on whitespace and seperate the strings into arrays
                string[] ssize = v.Split(null);
                
                DateTime dt;
                if(!DateTime.TryParse(ssize[4], out dt))
                {
                    MessageBox.Show("An error has occured trying\nto parse " +
                        "DateTime from " + ssize[4]);
                }

                // Add a new game to Data list with param from ssize
                Data.Add(new Game(i, int.Parse(ssize[0]), char.Parse(ssize[1]), int.Parse(ssize[2]), int.Parse(ssize[3]), dt));

                // Add 1 to counter
                i++;
            }

            // Return Data list
            return Data;
        }

        /// <summary>
        /// Saves a string of data to a file
        /// </summary>
        /// <param name="s"></param>
        public static void SaveDataString(string dir, string s)
        {
            // If file doesn't exist, create it
            if (!File.Exists(dir)) using (StreamWriter sw = File.CreateText(dir)) sw.WriteLine(s);

            // Append string to file
            File.AppendAllText(dir, "\n" + s);
        }

        /// <summary>
        /// Inserts a string list into a text box
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="list"></param>
        public static void InsertData(ListBox lb, List<Game> list)
        {
            // Add the header string to the items in listbox
            if(lb != null) lb.Items.Add(_header);

            // Foreach variable in list, add that item to the listbox
            foreach(var v in list) lb.Items.Add(v.GameString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="lb"></param>
        /// <param name="list"></param>
        public static void ReloadData(string dir, ListBox lb, List<Game> list)
        {
            // Clear all items from the list box
            lb.Items.Clear();

            // Clear all items from the list
            list.Clear();

            // Add items to the list
            list = ReadAllData(dir);
   
            // Add the header string to the listbox
            lb.Items.Add(_header);

            // Foreach variable in Data, add item to the listbox
            foreach(var v in Data) lb.Items.Add(v.GameString());
        }
    }
}