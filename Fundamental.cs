using System;

namespace firstscharp
{
    class Fundamental
    {
        public static void Print1to255(){
            for (int i=1; i<=255;i++)
            {
                Console.WriteLine(i);
            }
            for (int i=1; i<=100; i++)
            {
                int a = i%3; 
                int b = i%5;
                if (a.Equals(0) && !b.Equals(0))
                {
                    Console.WriteLine($"{i} is Fizz");
                }
                else if ( a!=0 && b==0 )
                {
                    Console.WriteLine($"{i} is Buzz");
                }
                else if ( a==0 && b == 0 )
                {
                    Console.WriteLine($"{i} is FizzBuzz");   
                }
            }
            int j= 1;
            while (j<=100)
            {
                int a = j%3; 
                int b = j%5;
                if (a.Equals(0) && !b.Equals(0))
                {
                    Console.WriteLine($"{j} is Fizz");
                }
                else if ( a!=0 && b==0 )
                {
                    Console.WriteLine($"{j} is Buzz");
                }
                else if ( a==0 && b == 0 )
                {
                    Console.WriteLine($"{j} is FizzBuzz");   
                }
                j++;
            }
        } 
    }
} 