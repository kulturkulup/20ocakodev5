using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenciListesi = new Dictionary<int, string>();
            ogrenciListesi.Add(10, "Fikriye Nur");
            ogrenciListesi.Add(20, "Sevinç");
            ogrenciListesi.Add(30, "Kevser");
            ogrenciListesi.Add(40, "Muhammed Can");
            Console.WriteLine(ogrenciListesi[10]);
            Console.WriteLine(ogrenciListesi[20]);
            Console.WriteLine(ogrenciListesi[30]);
            Console.WriteLine(ogrenciListesi[40]);
            Console.WriteLine("-----------------------");

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(100, "Fatma");
            myDictionary.Add(200, "Hasan");
            Console.WriteLine("Id : " + myDictionary.Items1[0] + "\nİsim :" + myDictionary.Items2[0]);
            Console.WriteLine("Id : " + myDictionary.Items1[1] + "\nİsim :" + myDictionary.Items2[1]);

        }
    }
}
