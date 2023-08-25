using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null))
                return false;
            if (ignoreCase == false)
            {
                return words.Contains(word);
            }
            else
            {
                words = words.Select(x => x.ToLower());
                word = word.ToLower();
                return words.Contains(word);
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 1)
                return 0;

            if (str.All(x => x == str[0]))
                return -1;

            char unique = str.Last(x => str.Count(c => c == x) == 1);

            return str.LastIndexOf(unique);
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int counter = 1;
            int maxConsec = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxConsec)
                {
                    maxConsec = counter;
                }
            }
            return maxConsec;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n < 1)
            {
                return new double[0];
            }
            
            var nths = new List<double>();
            
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % n == 0)
                {
                    nths.Add(elements[i]);
                }
            }
            return nths.ToArray();
        }
    }
}
