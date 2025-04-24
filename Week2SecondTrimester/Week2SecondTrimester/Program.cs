
using System.Data;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        //1. identify the false statement
        //Console.WriteLine("3-6");
        //for (int i = 3; i <= 6; i++)
        //{
        //    Console.Write(i + " ");
        //}
        //Console.WriteLine("\n4-9");
        //for (int i = 4; i <= 9; i++)
        //{
        //    Console.Write(i + " ");
        //}

        //Console.WriteLine("\n5-12");
        //for (int i = 5; i <= 12; i++)
        //{
        //    Console.Write(i + " ");
        //}

        //2. The program adds 7 user entered number and displays the total sum result.

        //3.

        //int iIndex, iVal, iTotal =0;
        //for (iIndex = 1; iIndex <= 5; iIndex++)
        //{
        //    Console.WriteLine("\nEnter a number");
        //    iVal = Convert.ToInt32(Console.ReadLine()); 
        //    iTotal = iTotal+iVal;
        //}
        //Console.WriteLine($"Total is =  {iTotal}");


        //4. 
        //int iNumber;
        //Console.WriteLine("Enter number to print the multiplication table!");
        //iNumber = Convert.ToInt32(Console.ReadLine());
        //for (int i = 1; i <= 10; i++)
        //{


        //    Console.WriteLine($"{iNumber} * {i} = {iNumber * i}");
        //}

        //5.ask user input for loop range

        //Console.WriteLine(" Enter minimum number for loop");
        //int  iMin = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter maximum number for loop");
        //int iMax = Convert.ToInt32(Console.ReadLine());
        //for (; iMin<=iMax; iMin++)
        //{
        //    Console.Write(iMin + " ");
        //}

        //6. nested for loop

        int iMax = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= iMax; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //hmw reverse numbers using while loop
        //prime number using for loop
    }
}