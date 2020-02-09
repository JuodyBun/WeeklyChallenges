using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int total = vals.Count();
            return total % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;   
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0 )
            {
                return 0;
            }
            else
            {
                double minNum = numbers.Min();
                double maxNum = numbers.Max();
                return minNum + maxNum;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int evenSum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                } 
            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = numbers.Sum();
            return (sum % 2 != 0) ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int oddCount = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    oddCount++;
                }
            }
            return oddCount;
        }
    }
}
