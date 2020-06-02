using System;
using System.Collections.Generic;
namespace firstscharp
{
    class Program
    {   
        static void Main(string[] args)
        {   
            // Fundamental.Print1to255();
            // ThreeBasicArray.ThreeArray();
            // IceCream.flavors();
            // Dictionary.Create_dict();
            foreach( object a in Object.objectList())
            {
                if ( a is int )
                {
                    Console.WriteLine($"this is an interger: {a}");
                }
                else if (a is string)
                {
                    Console.WriteLine($"This is a string: {a}");
                }
            }
        }
    }
}
