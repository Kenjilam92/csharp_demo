using System;

namespace firstscharp
{
    class ThreeBasicArray
    {   
        public static string[] ThreeArray()
        {   
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] stringArray = {"Tim","Martin", "Nikki", "Sara"};
            bool[] boolArray = new bool[10];
            for (int i = 0; i< boolArray.Length;i++)
            {
                if ((i%2)== 0)
                {
                    boolArray[i]=true;
                }
                else
                {
                    boolArray[i] = false;
                }
            }
            return stringArray;
        }
    }
}