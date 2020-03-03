using System;
using System.IO;

namespace Algorithms_and_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileContents = File.ReadAllText(@"C:\Users\hardc\source\repos\Algorithms and Complexity\NTD\Net_1_256.txt");
            string newline = '\r'.ToString() + '\n'.ToString();
            fileContents = fileContents.Replace(newline, '\n'.ToString());
            string[] array = fileContents.Split(new char[] { '\n' });
            int[] intArray = new int[array.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                int.TryParse(array[i], out intArray[i]);
            }
            foreach (int i in intArray)
                Console.WriteLine(i);

            Console.Read();

        }
    }
}

