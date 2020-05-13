using System;
using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel;
using System.IO;

namespace ReadFile.Mix.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines1 = File.ReadAllLines(@"C:\Users\Svea User\Source\Repos\ReadFile.Mix.Sort\TextFile1.txt");
            var lines2 = File.ReadAllLines(@"C:\Users\Svea User\Source\Repos\ReadFile.Mix.Sort\TextFile2.txt");

            string[] field = new string[20];
            int fieldIndex = 0;
            for (int i = 0; i < lines1.Length; i++)
            {
                string[] lines = lines1[i].Split(' ');
                foreach (var item in lines)
                {
                    field[fieldIndex] = item;
                    fieldIndex++;
                }
            }
            for (int i = 0; i < lines2.Length; i++)
            {
                string[] lines = lines2[i].Split(' ');
                foreach (var item in lines)
                {
                    field[fieldIndex] = item;
                    fieldIndex++;
                }
            }

            Array.Sort(field);
            foreach (string item in field)
            {
                Console.WriteLine(item);
            }
        }
    }

}
