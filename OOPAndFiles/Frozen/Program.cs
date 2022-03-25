using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Wishes
        {
            string who;
            string wish;
            


            public Wishes(string _who, string _wish)
            {
                who = _who;
                wish = _wish;
                
            }

            public string Who
            {
                get { return who; }
            }

            public string Wish
            {
                get { return wish; }
            }

            

        }

        static void Main(string[] args)
        {
            List<Wishes> myMovies = new List<Wishes>();
            string[] moviesFromFile = GetDatFromFile();

            foreach (string line in moviesFromFile)
            {
                string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Wishes newMovie = new Wishes(tempArray[0], tempArray[1]);
                myMovies.Add(newMovie);
                //Console.WriteLine($"title from TempArray: {tempArray[0]}");
                //Console.WriteLine($"rating from TempArray: {tempArray[1]}");
                //Console.WriteLine($"year from TempArray: {tempArray[2]}");
            }
            foreach (Wishes movieFromList in myMovies)
            {
                Console.WriteLine($"{movieFromList.Who} wants for chistmas {movieFromList.Wish}.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDatFromFile()
        {
            string filePath = @"C:\Users\koll7\Desktop\Programmeerimine\MI\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
