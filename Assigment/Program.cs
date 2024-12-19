namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.


            Console.WriteLine("Enter the Number");
            int Number = int.Parse(Console.ReadLine());

            if (Number%3==0 && Number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }




            #endregion
        }
    }
}