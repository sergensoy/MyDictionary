using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Sergen");
            myDictionary.Add(2, "Ahmet");
            myDictionary.Add(3, "Ali");
            myDictionary.Add(4, "Veli");
            myDictionary.Add(5, "Mesut");
            myDictionary.Add(6, "Pelgas");
            myDictionary.Add(7, "İrfan");

            Console.WriteLine(myDictionary.Count);
        }
    }
}
