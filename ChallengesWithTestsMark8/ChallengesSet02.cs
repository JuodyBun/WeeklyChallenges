using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsSymbol(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int total = vals.Count();
            if (total % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double minNum = numbers.Min();
            double maxNum = numbers.Max();
            return minNum + maxNum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;

            if (length1 > length2)
            {
                return length2;
            } else
            {
                return length1;
            }
        }

        public int Sum(int[] numbers)
        {
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int even = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += numbers[i];
                }
            }
            return numbers.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = numbers.Sum();
            if (sum % 2 != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
