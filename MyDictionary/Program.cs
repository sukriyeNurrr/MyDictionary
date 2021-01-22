using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "ilk ürün");
            myDictionary.Add(2, "ikinci ürün");
            myDictionary.Add(3, "Üçüncü ürün");
        }
    }
}
