using System;
using System.Diagnostics.Eventing.Reader;

namespace Assigment
{
    internal class Assigment
    {
        static void Main(string[] args)
        {
            #region Q1:1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.


            //  Console.WriteLine("Enter the Number");
            //  int Number = int.Parse(Console.ReadLine());

            //  if (Number%3==0 && Number % 4 == 0)
            //  {
            //     Console.WriteLine("Yes");
            //  }
            // else
            // {
            //     Console.WriteLine("No");
            // }

            #endregion




            #region Q2: Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("Enter integer Number");

            //int Number = int.Parse(Console.ReadLine());

            //if (Number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else if (Number > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else
            //{
            //    Console.WriteLine("Number is Zero");
            //}



            #endregion


            #region Q3: Write a program that takes 3 integers from the user then prints the max element and the min element.

            Console.WriteLine("Enter first Number ");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter  second Number ");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third Number ");

            int num3 = int.Parse(Console.ReadLine());


           int maxNumber = num1;
            int minNumber = num1;

            if (num2 > maxNumber)
            {
                maxNumber = num2;
            }
            else if (num2 < minNumber)
            {
                minNumber = num2;
            }

            if (num3 > maxNumber)
            {
                maxNumber = num3;
            }
            else if (num3 < minNumber)
            {
                minNumber = num3;
            }

            Console.WriteLine( $" Max element = {maxNumber}");

            Console.WriteLine($" Min element = {minNumber}");






            #endregion


        }
    }
}