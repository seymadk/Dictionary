using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> array = new MyDictionary<int, string>();
            array.Add(1, "Ayse");
            array.Add(2, "Fatma");

        }
    }
}
