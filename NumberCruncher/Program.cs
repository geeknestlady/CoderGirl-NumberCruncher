using System;
using System.Collections.Generic;


namespace NumberCruncher
{
    public static class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();
            int number = 0;
            for (int i = 0; i < 20; i++)
            {
                number = new Random().Next(1, 100);
                numbers.Add(number);
            }
            
            
            Console.WriteLine(NumberUtility.NumberUtility.SumOfEvenNumbers(numbers));

            //Create a list of ints 
            //Call SumOfEvenNumbers in NumberUtility and pass this list in
            //Pring out the result
            Console.ReadLine();
        }
    }
}
