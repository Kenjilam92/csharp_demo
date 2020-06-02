using System;
using System.Collections.Generic;
namespace firstscharp
{
    class Object
    {   
        public static List<object> objectList ()
        { 
            List<object> objectList = new List<object>();
            objectList.Add(7);
            objectList.Add(28);
            objectList.Add(-1);
            objectList.Add(true);
            objectList.Add("chair");
            return objectList;
        }
        public static void analyzing( List<object> test)
        {
            int total = 0;
            foreach( object a in test)
            {
                if (a is bool)
                {
                    Console.WriteLine($"this is a boolean: {a}");
                }
                if ( a is int)
                {
                    int number = (int)a;
                    total += number;
                    Console.WriteLine($"this is an interger: {a}");
                }
                else if (a is string)
                {
                    Console.WriteLine($"This is a string: {a}");
                }
            }
            Console.WriteLine($"total of intergers is: {total}");
        }
    }
}