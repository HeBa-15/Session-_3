using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;

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

            // Console.WriteLine("Enter first Number ");

            // int num1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter second Number ");

            // int num2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter third Number ");

            // int num3 = int.Parse(Console.ReadLine());


            //int maxNumber = num1;
            // int minNumber = num1;

            // if (num2 > maxNumber)
            // {
            //     maxNumber = num2;
            // }
            // else if (num2 < minNumber)
            // {
            //     minNumber = num2;
            // }

            // if (num3 > maxNumber)
            // {
            //     maxNumber = num3;
            // }
            // else if (num3 < minNumber)
            // {
            //     minNumber = num3;
            // }

            // Console.WriteLine( $" Max element = {maxNumber}");

            // Console.WriteLine($" Min element = {minNumber}");






            #endregion



            #region Q4:Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("Enter integer Number");

            //int num = int.Parse(Console.ReadLine());

            //if(num%2==0)
            //    Console.WriteLine("Number is Even"); 
            //else
            //    Console.WriteLine("Number is Odd");

            #endregion


            #region Q5:Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.WriteLine("Enter Char");
            //char ch = char.Parse(Console.ReadLine());
            //if (ch == "a" || ch == "e" || ch == "i" || ch == "o"|| ch == "u")
            //{
            //    Console.WriteLine("the char is vowel");

            //}
            //else
            //{
            //    Console.WriteLine("the char is Consonant");

            //}
            #endregion


            #region Q7: Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.WriteLine("Enter integer");

            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(num * i);

            //}

            #endregion


            #region Q9: Write a program that takes two integers then prints the power.

            //Console.WriteLine("Enter the base");
            //int base=int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the exponent");
            //int exponent = int.Parse(Console.ReadLine());

            //int res = 1;
            //for (int i = 0; i < exponent; i++)
            //{
            //    res *= base;
            //}
            //Console.WriteLine(res);

            #endregion


            #region Q10: Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("Enter Marks of subject 1");
            //int mark1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Marks of subject 2");
            //int mark2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Marks of subject 3");
            //int mark3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Marks of subject 4");
            //int mark4 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Marks of subject 5");
            //int mark5 = int.Parse(Console.ReadLine());


            //float sum = mark1 + mark2 + mark3 + mark4 + mark5;

            //float avg = sum / 5;

            //float percentage = (sum / 500) * 100;

            //Console.WriteLine($"Total marks = {sum}");
            //Console.WriteLine($"Average Marks = {avg}");
            //Console.WriteLine($"Percentage = {percentage}");


            #endregion


            #region Q11: Write a program to input the month number and print the number of days in that month.

            //Console.WriteLine("Enter Month Number : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 || monthNumber == 8 || monthNumber == 10 || monthNumber == 12)
            //{
            //    Console.WriteLine("Days in Month: 31");
            //}
            //else if (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
            //{
            //    Console.WriteLine("Days in Month: 30");
            //}
            //else if (monthNumber == 2)

            //{
            //    Console.WriteLine("Enter the Year :");
            //    int year = int.Parse(Console.ReadLine());
            //    if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            //    {
            //        Console.WriteLine("Days in Month: 29");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Days in Month: 28");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid month number");
            //}


            #endregion


            #region Q17: Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.Write("Enter x1: ");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //int y1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter x2: ");
            //int x2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //int y2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter x3: ");
            //int x3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //int y3 = int.Parse(Console.ReadLine());

            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //} 
            //else 
            //{
            //    Console.WriteLine("The points do not lie on a single straight line."); 
            //}

            #endregion


            #region Q18:



            // Console.Write("Enter Hours : ");
            //int hours = int.Parse(Console.ReadLine()); 

            //if (hours >= 2 && hours < 3) 
            //{
            //    Console.WriteLine("Highly efficient");
            //}
            //else if (hours >= 3 && hours < 4)
            //{
            //    Console.WriteLine("Increase your speed"); 
            //}
            //else if (hours >= 4 && hours < 5)
            //{ 
            //    Console.WriteLine("training to improve your speed"); 
            //} 
            //else if (hours >= 5) 
            //{ 
            //    Console.WriteLine(" leave the company");
            //} 
            //else 
            //{ 
            //    Console.WriteLine("Invalid input"); 
            //}
            #endregion


            #region Q21:Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen


            //int Value1 = 7;
            //int Value2;
            //Value2 = Value1; //7

            //Value1 = 10;

            //Console.WriteLine(Value1); // 10
            //Console.WriteLine(Value2); // 7





            #endregion


            #region Q22:Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //object obj1 = new object();
            //obj1 = 5;

            //object obj2 = new object();
            //obj2 = obj1; //5


            //obj1 = 10;
            //Console.WriteLine(obj1); // 10

            //Console.WriteLine(obj2); // 5



            #endregion


            #region Q23:Which of the following statements is correct about the C#.NET code snippet given below?

            //  int d;
            // // 1                      //true
            //  d = Convert.ToInt32(!(30 < 20));

            ////  A value 1 will be assigned to d.

            ////   على حسب حلي بس لما عملت
            ////   run مطلعش اي قيمة





            #endregion


            #region Q24:Which of the following is the correct output for the C# code given below?

            //                    //6.5 +" " + 1
            //                    //6  + " "+ 1
            //Console.WriteLine(13 / 2 + " " + 13 % 2);


            // d) 6 1



            #endregion


            #region Q25: What will be the output of the C# code given below?


            int num = 1, z = 5;

                    //true
            if (!(num <= 0))
                                  //2   +   5 + " " +  7
                                  //7 " " 7
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);



            #endregion

        }
    }
}