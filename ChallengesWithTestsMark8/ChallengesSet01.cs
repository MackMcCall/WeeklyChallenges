using System;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var difference = minuend - subtrahend;
            return difference;
        }

        public int Add(int number1, int number2)
        {
            var sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            var smallestNum = (number1 >= number2) ? number2 : number1;
            return smallestNum;
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            return (string.IsNullOrEmpty(nameOfPerson)) ? "Hello!" : $"Hello, {nameOfPerson}!";
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
