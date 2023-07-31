using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return Math.Abs(num) % 2 == 1;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers != null && numbers.Count() > 0 ? numbers.Max() + numbers.Min() : 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            
            int evensSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evensSum += numbers[i];
                }
            }
            return evensSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers != null && Math.Abs(numbers.Sum()) % 2 == 1);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int countPosOdds = 0;
            if (number > 0)
            {
                for (long i = number - 1; i > 0; i--)
                {
                    if (i % 2 == 1)
                    {
                        countPosOdds += 1;
                    }
                }
                return countPosOdds;
            }
            else
            {
                return 0;
            }
        }
    }
}
