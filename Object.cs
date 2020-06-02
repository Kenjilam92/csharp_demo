using System;
using System.Collections.Generic;
namespace firstscharp
{
    class Object
    {   
        public static List<object> objectList ()
        { 
            List<object> objectList = new List<object>();
            objectList.Add(2);
            objectList.Add(5);
            objectList.Add("hello");
            return objectList;
        }
    }
}