using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{
    class Program
    {
        class Movies
        {
            string title;
            string rating;
            string year;


            public Movies(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }

            public string Title
            {
                get { return title; }
            }

            public string Rating
            {
                get { return rating; }
            }

            public string Year
            {
                get { return year; }
            }

        }
        
        static void Main(string[] args)
        {
            List<Movies> myMovies = new List<Movies>();
            string[] moviesFromFile = GetDatFromFile();

            foreach(string line in moviesFromFile)
            {
                string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movies newMovie = new Movies(tempArray[0], tempArray[1], tempArray[2]);
                myMovies.Add(newMovie);
                //Console.WriteLine($"title from TempArray: {tempArray[0]}");
                //Console.WriteLine($"rating from TempArray: {tempArray[1]}");
                //Console.WriteLine($"year from TempArray: {tempArray[2]}");
            }
            foreach(Movies movieFromList in myMovies)
            {
                Console.WriteLine($"Title --> {movieFromList.Title}. Rating --> {movieFromList.Rating}. Year --> {movieFromList.Year}.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDatFromFile()
        {
            string filePath = @"C:\Users\koll7\Desktop\Programmeerimine\MI\movies.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }


    
}
