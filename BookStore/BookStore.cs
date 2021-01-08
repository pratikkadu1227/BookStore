using System;

namespace BookStore
{
    /// <summary>
    /// Created By : Pratik kadu
    /// Created On : 7 January 2021
    /// Purpose : To display Books with cost details on console
    /// Description : As per my understanding , this task is more of displaying data on consiole and hence I kept calculations 
    /// hard coded for Tax and Total Cost
    /// </summary>
    class BookStore
    {
        static int tableWidth = 110;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enjoy 5% discount on Crime category Books!");
            Console.WriteLine("Total tax for the whole order is 10%");
            AddRowData("Book Name", "Category", "Total Cost","With Tax", "Without Tax");
            AddLine();
            AddRowData("Unsolved crimes", "Crime", "10.99", "11.48","10.44");
            AddRowData("A Little Love Story", "Romance", "2.40", "2.64","2.40");
            AddRowData("Heresy", "Fantasy", "6.80", "7.48", "6.80");
            AddRowData("Jack the Ripper", "Crime", "16.00", "16.72", "15.20");
            AddRowData("The Tolkien Years", "Fantasy", "22.90", "25.19", "22.90");
            AddLine();
            AddRowData(" ", "Total", "59.09", "63.51", "57.74");
            AddLine();
            Console.ReadLine();
        }
        static void AddLine()
        {
            //Initializes a new instance of string class to the value indicated by the repeated number of time which is 110 in tablewidth variable
            Console.WriteLine(new string('_', tableWidth));
        }
        static void AddRowData(params string[] columns)
        {
            string row = "|"; // string variable to append | and data
            foreach (string column in columns)
            {
                row += column.PadRight(20).PadLeft(20) + "|"; // Foreach loop for ading data into table format 
            }
            Console.WriteLine(row);
        }
    }
}
