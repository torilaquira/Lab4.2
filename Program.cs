using System;

namespace OddEvenPractice
{
    public class Numbers
    {
        public static string EvenNumbers(int num)
        {

            if (num % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }



        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Numbers.EvenNumbers(2));
           for (int i=1; i<=100; i++)
            {
                Console.WriteLine($"{i} {Numbers.EvenNumbers(i)}");
            }
           
            
        }
    }
}
