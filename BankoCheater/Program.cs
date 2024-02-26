/* namespace BankoCheater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
*/
/////////////////////////
////////////////////////


using System.Collections.Generic;

int[] calledNumbers = new int[90];
string[] activeTables = new string[3]; //Change to list for dynamic length later

/*static arrays for loop setup and testing*/
int[] temporaryTestArray1 = new int[12] {3,21,40,62,85,11,7,55,44,2,25,88};
int[] temporaryTestArray2 = new int[12] {4,41,54,84,32,66,20,30,69,18,65,76};

Dictionary<string, int[]> cheatTables = new Dictionary<string, int[]>();
cheatTables.Add("Plade1", new int[] {3,14,26,43,56,15,44,62,76,87,17,29,37,65,77});
cheatTables.Add("Plade2", new int[] {4,10,21,31,54,32,47,57,66,75,24,38,59,76,88});
cheatTables.Add("Plade3", new int[] {3,20,30,40,62,18,34,41,54,84,5,29,69,79,85});
activeTables[0] = "Plade1";
activeTables[1] = "Plade2";
activeTables[2] = "Plade3";

temporaryTestArray1.CopyTo(calledNumbers, 0);
temporaryTestArray2.CopyTo(calledNumbers, 12);
//Array.ForEach(calledNumbers, Console.WriteLine);

if (calledNumbers.Length > 5)
{ //only test once necessary
    foreach (string tableID in activeTables)
    {
        Console.WriteLine("Table outer loop");
        for (int i = 0, count = 0; i<15; i++)
        {
            if (i == 0 || i == 5 || i == 10) { count = 0; }
            if (calledNumbers.Contains(cheatTables[tableID][i])) { 
                Console.WriteLine($"numTrigger{i}-{cheatTables[tableID][i]}");
                count++;
            }
            if (count == 5) { Console.WriteLine($"Win on table {tableID}!"); }

        }
    }
}