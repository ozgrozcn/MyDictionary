using System;
using System.Collections.Generic;
namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, string> cities = new MyDictionary<string, string>();
            cities.Add("Ankara", "Çankaya");
            cities.Add("Kırıkkale", "Yenimahalle");
            cities.Add("İstanbul", "Ataşehir");

            // Control of adding same key to dictionary
            cities.Add("İstanbul", "Ataşehir");

            Console.WriteLine("------------------------------------");
            // Using GetKeys with value return function
            string[] result;
            cities.GetKeys(out result); // Returned keys to result argument.

            // Using GetKeys with list to keys function
            cities.GetKeys();

            Console.WriteLine("------------------------------------");
            // Using GetValueByKey method with exist and non-exist keys.
            Console.WriteLine(cities.GetValueByKey("Ankara")); // for exist key
            Console.WriteLine(cities.GetValueByKey("Antalya")); // for non-exist key
        }
    } 
}