using System;

namespace UsingDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(01, "Adana");
            myDictionary.Add(06, "Ankara");
            myDictionary.Add(38, "Kayseri");
            myDictionary.Print();
        }
    }
}
