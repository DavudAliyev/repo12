using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = SumOfNums(5, 6, 8);
            Console.WriteLine(sum);
        }

        //Verilmiş 3 ədədin cəmini tapan method (həm int, həm double ədədlər üçün)
        static int SumOfNums(double num1,double num2, double num3) 
        {
            int sum = (int) (num1 + num2 + num3);
            return sum;
        }

        //Verilmiş ədədlər siyahısındaki bütün ədədlərin cəmini tapan method (həm int, həm double ədədlər üçün)

        static int SumOfAllNums(double[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];               
            }
            return sum;
        }

        //Verilmiş yazıda veirlmiş charın yerləşdiyi ilk indexi tapan method (yoxdursa -1 qaytarı)

        static int FindFirstIndex(string text, char wantedChar)
        {
            for (int i = 0;i < text.Length;i++)
            {
                if (wantedChar == text[i])
                    return i;
            }
            return -1;
        }

        //Verilmiş yazıda veirlmiş charın yerləşdiyi son indexi tapan method (yoxdursa -1 qaytarı)

        static int FindLastIndex(string text1, char lastChar)
        {
            for (int i=text1.Length-1; i>=0; i--)
            {
                if (lastChar == text1[i])
                    return i;
            }
            return -1;
        }

        //Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan method
        static int FindBiggest(int[]arr)
        {
            int maxnum = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] > maxnum)
                    maxnum = arr[i];
                return maxnum;
            }
            return arr[0];

        }

        //Verilmiş ədədin müsbət və cüt olub olmadığını tapan method
        static int CheckNum(int num)
        {
            if (num > 0 && num % 2 == 0)
                return num;
            else return -1;
        }

        //Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərin sayını tapan method

        static int FindNum(int[] arr)
        {
            int count = 0;

            for(int i=0;i < arr.Length;i++)
            {
                if (arr[i] > 0 && arr[i]%2==0)
                    count++;
                return count;
            }
            return -1;
        }

        //Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərdən ibarət yeni bir array düzəldən method.

        static int NewArray(int[] arr, string arr1)
        {
            string arr2 = "";

            for(int i=0;i<=arr1.Length;i++)
            {
                if (arr1[i] > 0 && arr1[i]%2==0)
                {
                    arr1 += arr2;
                    return arr2;
                }
                return -1;
            }
        }

        //Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən method

        static string RemoveLeftSpace(string str)
        {
            string newStr = "";
            int startIndex = FindFirstNonSpaceIndex(str);

            if (startIndex == -1)
                return str;

            for(int i = startIndex; i < str.Length; i++)
            {
                newStr+= str[i];
            }
            return newStr;
        }
        static int FindFirstNonSpaceIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') return i;
            }

            return -1;
        }


        //Verilmiş yazıdan sonundaki boşluqlar silinmiş yeni string düzəldən method

        static string RemoveRightSpace(string str)
        {
            string newStr = "";
            int startIndex = FindFirstLastSpaceIndex(str);

            if (startIndex == -1)
                return str;

            for (int i = startIndex-1; i >=0; i--)
            {
                newStr += str[i];
            }
            return newStr;
        }

        static int FindFirstLastSpaceIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') return i;
            }

            return -1;
        }
    }
}
