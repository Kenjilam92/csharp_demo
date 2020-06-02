using System;
using System.Collections.Generic;
namespace firstscharp
{
    class Dictionary
    {   
        public static Dictionary<string,string> Create_dict()
        {   
            Dictionary<string,string> profile = new Dictionary<string, string>();
            for (int i =0; i < ThreeBasicArray.ThreeArray().Length && i < IceCream.flavors().Count; i++)
            {
                profile.Add(ThreeBasicArray.ThreeArray()[i],IceCream.flavors()[i]);
                Console.WriteLine($"{ThreeBasicArray.ThreeArray()[i]} : " + profile[ThreeBasicArray.ThreeArray()[i]]);
            }
            return profile;
        }
    }
}