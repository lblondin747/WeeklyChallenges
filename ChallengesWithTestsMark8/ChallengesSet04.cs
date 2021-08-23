using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int num = 0;
            foreach(var i in numbers)
            {
                num += (i % 2 == 0) ? i : -i;
            }
            return num;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int i = str1.Length;
            if (str2.Length < i)
                i = str2.Length;
            if (str3.Length < i)
                i = str3.Length;
            if (str4.Length < i)
                i = str4.Length;
            return i;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int i = number1;
            if (number2 < i)
                i = number2;
            if (number3 < i)
                i = number3;
            if (number4 < i)
                i = number4;
            return i;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1+sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
            double output = 0;
            return double.TryParse(input, out output);
                
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int maj = objs.Length / 2;
            int count = 0;
            foreach (var i in objs)
                count += (i == null) ? 1 : 0;
            return (count > maj) ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            double count = 0;
            double sum = 0;
            foreach(var i in numbers)
            {
                if(i%2==0)
                {
                    sum += i;
                    count++;
                }
            }
            return (count == 0) ? 0 : sum / count;
        }

        public int Factorial(int number)
        {
            if (number == 0)
                return 1;
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            int returnVal = number;
            for (int i = number-1; i > 0; i--)
            {
                returnVal *= i;
            }
            return returnVal;
        }
    }
}
