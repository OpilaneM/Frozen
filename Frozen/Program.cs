using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Wish
        {
            string reciver;
            string present;

            public Wish (string _reciver, string _present)
            {
            reciver = _reciver;
            present = _present;
            }
            public string Reciver
            {
                get { return reciver; }
            }
            public string Present
            {
                get { return present; }
            }
        }

        static void Main(string[] args)
        {
            // Anna wants new earrings for christmas
            List<Wish> myWish = new List<Wish>();
            string[] PresentFile = GetDataFromFile();

            foreach (string line in PresentFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Wish newWish = new Wish(tempArray[0], tempArray[1]);
                myWish.Add(newWish);
            }
            foreach(Wish PresentFromList in myWish)
            {
                Console.WriteLine($"{PresentFromList.Reciver} wants a new {PresentFromList.Present}");
            }

            Console.Read();


        }
        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"string from array {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\mraud\source\repos\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;

        }
    }
}
