using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var inputStrings = new List<string>() { str1, str2, str3, str4 };
            string shortest = str1;
            for (int i = 0; i < inputStrings.Count; i++)
            {
                if (inputStrings[i].Length < shortest.Length)
                {
                    shortest = inputStrings[i];
                }
            }
            return shortest.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var inputInts = new List<int>() { number1, number2, number3, number4 };
            int shortest = number1;
            for (int i = 0; i < inputInts.Count; i++)
            {
                if (inputInts[i] < shortest)
                {
                    shortest = inputInts[i];
                }
            }
            return shortest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 + sideLength2 <= sideLength3) || (sideLength1 + sideLength3 <= sideLength2) || (sideLength2 + sideLength3 <= sideLength1))
            {
                return false;
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {
            return input != null && (double.TryParse(input, out double dInput));
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int nonNull = 0;
            foreach (var item in objs)
            {
                if (item == null)
                {
                    nullCount++;
                }
                else
                {
                    nonNull++;
                }
            }
            return nullCount > nonNull;
            //int nullCount = 0;
            //foreach (var item in objs)
            //{
            //    if (item == null)
            //    {
            //        nullCount++;
            //    }
            //}
            //return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            
            double evenSum = 0;
            int evenCount = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenSum += num;
                    evenCount++;
                }
            }
            return evenCount > 0 ? evenSum / evenCount : 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 0)
            {
                return 1;
            }

            for (int i = number -1; i > 1; i--)
            {
                number *= i;
            }
            
            return number;
        }
    }
}
