using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvToSqliteConverter
{
    public partial class Form1 : Form
    {
        int counter = 0;
        string line;

        public Form1()
        {
            InitializeComponent();
        }


        private void Write_Click(object sender, EventArgs e)
        {
            // Read the file and display it line by line.  
            System.IO.StreamReader csvFile =
                new System.IO.StreamReader(@"D:\DailyMission\VmaAlertDescription\test.txt");

            System.IO.StreamReader dbFile =
new System.IO.StreamReader(@"D:\DailyMission\VmaAlertDescription\AlertDescriptionDb\AlertDescriptionTest.db");

            while ((line = csvFile.ReadLine()) != null)
            {
                System.Console.WriteLine(line);

                UpdateSqlSelfTestable(GetIsSelfTestable(line));

                counter++;
            }

            csvFile.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }

        private void BrowseYourFile_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader csvFile =
    new System.IO.StreamReader(@"D:\DailyMission\VmaAlertDescription\test.txt");

        }

        private void BrowsYourDB_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader dbFile =
    new System.IO.StreamReader(@"D:\DailyMission\VmaAlertDescription\AlertDescriptionDb\AlertDescriptionTest.db");

        }


        private bool GetIsSelfTestable(string targetString)
        {
            bool ret = false;
            string[] words = targetString.Split(',');
            //Parse "Slot5", "010000000" out
            


            //Extract IsSelfTestable

            return ret;
        }

        private void UpdateSqlSelfTestable(bool isSelfTestable)
        {

        }


    }
}
