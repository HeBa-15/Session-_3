﻿using System;
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

            Console.WriteLine("Enter integer Number");

            int Number = int.Parse(Console.ReadLine());

            if (Number < 0)
            {
                Console.WriteLine("negative");
            }
            else if (Number > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }



            #endregion


            #region Q3: Write a program that takes 3 integers from the user then prints the max element and the min element.



            #endregion

        }
    }
}