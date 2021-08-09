using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            int i = (int)c;
            if (i <= 90 && i >= 65)
                return true;
            else if (i <= 122 && i >= 97)
                return true;
            else
                return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int c = 0;
            foreach (var a in vals)
            {
                c++;
            }
            return (c % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 == 0) ? false : true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if (numbers == null)
                return 0;
            else if (numbers.Count() == 0)
                return 0;
            else
                return numbers.Min(x => x) + numbers.Max(x => x);
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;
            else
                return numbers.Sum(x => x);
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            else
                return numbers.Where(x => x%2 == 0).Sum(x=>x);
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            else
                return (numbers.Sum(x => x) % 2 == 0) ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
                return 0;
            return (number % 2 == 0) ? number/2 : (number-1)/2;
        }
    }
}
