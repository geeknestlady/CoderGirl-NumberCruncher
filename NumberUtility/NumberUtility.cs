using System;
using System.Collections.Generic;
using System.Text;

namespace NumberUtility
{
    public static class NumberUtility
    {
        //create a static method SumOfEvenNumbers 
        //it should take a list of ints and returns the sum of all even number in that list
        public static int SumOfEvenNumbers(List<int> numbers)
        {
            int sumOfInts = 0;
            List<int> evenNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            foreach (int evenNumber in evenNumbers)
            {
                sumOfInts += evenNumber;
            }
            return sumOfInts;
        }
    }
}
