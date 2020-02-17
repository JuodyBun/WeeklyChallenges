using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Any(x => !x);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int oddSum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    oddSum += i;
                }
            }
            return (oddSum % 2 != 0) ? true : false; 
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return (password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit)) ? true : false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char first = val.ToCharArray().ElementAt(0);
            return first;
        }

        public char GetLastLetterOfString(string val)
        {
            char last = val[val.Length - 1];
            return last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) 
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            int last = nums[nums.Length - 1];
            int first = nums.ElementAt(0);
            return last-first;
        }

        public int[] GetOddsBelow100()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            int[] odds = new int[numbers.Count]; 
            for (int x = 0; x < numbers.Count; x++)
            {
                odds[x] = numbers[x];
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
