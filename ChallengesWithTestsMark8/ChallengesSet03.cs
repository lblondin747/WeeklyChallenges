using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(var a in vals)
            {
                if (a == false)
                    return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            int sum = 0;
            foreach(var a in numbers)
            {
                if (a % 2 != 0)
                {
                    sum += a;
                }
            }
            if (sum % 2 != 0)
                return true;
            else
                return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;
            foreach(var a in password)
            {
                if ((int)a >= 65 && (int)a <= 90)
                    upper = true;
                else if ((int)a <= 122 && (int)a >= 97)
                    lower = true;
                else if ((int)a <= 57 && (int)a >= 48)
                    number = true;
            }
            if (number && lower && upper)
                return true;
            else
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            return dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length-1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var intList = new List<int>();
            for(int i = 100;i>0 ;i++)
            {
                if(i%2!=0)
                {
                    intList.Add(i);
                }
            }
            return intList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
