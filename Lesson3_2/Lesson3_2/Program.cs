using System;

namespace Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array with data
            string[,] phoneBook = new string[5, 2] { 
                { "John Thomson", "555-44-33 / j.thomson@email.com" }, 
                { "James Cook", "555-44-34 / j.cook@email.com" }, 
                { "Ben David", "555-44-35 / b.david@email.com" }, 
                { "Hannah Meier", "555-44-36 / h.meier@email.com" }, 
                { "Julia Elsenheimer", "555-44-37 / j.elsenheimer@email.com" } };

            //showing the array
            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                Console.WriteLine(phoneBook[i,0] + ": " + phoneBook[i,1]);
            }
        }
    }
}
