using System;
using System.Collections.Generic;
namespace firstscharp
{
    class IceCream
    {   
        public static List<string> flavors()
        {   
            List<string> flavors = new List<string>();

            flavors.Add("mint");
            flavors.Add("vanila");
            flavors.Add("durian");
            flavors.Add("strawberry");
            flavors.Add("grape");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);
            return (flavors);
        }
    }
}