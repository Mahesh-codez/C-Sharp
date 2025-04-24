using System;
using System.Diagnostics.CodeAnalysis;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations;
internal class Program
{
    private static void Main(string[] args)
    {
        //int iSalesAmount;
        //int iBonus = 0;
        //Console.WriteLine(" Enter sales amount");
        //iSalesAmount = Convert.ToInt32(Console.ReadLine());

        //if (iSalesAmount >= 0 && iSalesAmount <= 9999)
        //{
        //    iBonus = (iSalesAmount >= 0 && iSalesAmount <= 1000) ? 50 : (iSalesAmount >= 1001 && iSalesAmount <= 5000) ? 200 : 600;
        //}

        //Console.WriteLine($"Bonus is: £{iBonus}");

        TicketCostFunction();
    }
    private static void TicketCostFunction()
    {
        //int iAreaCode, inumberOfSeats, iticketPrice;

        //Console.WriteLine("Enter number of seats");
        //inumberOfSeats = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter code number to book seat on desired area\n1 = Stalls, 2 = Grand Circle, 3 = Upper Circle, 4 = Gallery");
        //iAreaCode = Convert.ToInt32(Console.ReadLine());

        //switch (iAreaCode)
        //{
        //    case 1:

        //        iticketPrice = 24 * inumberOfSeats;
        //        Console.WriteLine($"Ticket price is: £{iticketPrice} for Stalls");
        //        break;

        //    case 2:
        //        iticketPrice = 30 * inumberOfSeats;
        //        Console.WriteLine($"Ticket price is: £{iticketPrice} for Grand Circle");
        //        break;

        //    case 3:
        //        iticketPrice = 27 * inumberOfSeats;
        //        Console.WriteLine($"Ticket price is: £{iticketPrice} for Upper Circle ");
        //        break;

        //    case 4:

        //        iticketPrice = 20 * inumberOfSeats;
        //        Console.WriteLine($"Ticket price is: £{iticketPrice} for Gallery ");
        //        break;

        //    default:
        //        Console.WriteLine("Please select one area");
        //        break;



        //if (iAreaCode == 1)
        //{
        //    ticketPrice = 24  * inumberOfSeats;
        //    Console.WriteLine($"Ticket price is: £{ticketPrice} for Stalls");
        //}
        //else if (iAreaCode == 2)
        //{
        //    ticketPrice = 30 * inumberOfSeats;
        //    Console.WriteLine($"Ticket price is: £{ticketPrice} for Grand Circle");

        //}
        //else if (iAreaCode == 3)
        //{
        //    ticketPrice = 27 * inumberOfSeats;
        //    Console.WriteLine($"Ticket price is: £{ticketPrice} for Upper Circle ");

        //}
        //else if (iAreaCode == 4)
        //{
        //    ticketPrice = 20 * inumberOfSeats;
        //    Console.WriteLine($"Ticket price is: £{ticketPrice} for Gallery ");

        //}
        //else
        //{
        //    Console.WriteLine(" Please select area and enter number of required seats");
        //}

        //Console.WriteLine("Enter a number to select weekday");
        //int iweekNumber;
        //iweekNumber = Convert.ToInt32(Console.ReadLine());  
        //switch(iweekNumber) {
        //    case 1:
        //        Console.WriteLine("Sunday");
        //        break;
        //    case 2:
        //        Console.WriteLine("Monday");
        //        break;
        //    case 3:
        //        Console.WriteLine("Tuesday");
        //        break;
        //    case 4:
        //        Console.WriteLine("Wednesday");
        //        break;
        //    case 5:
        //        Console.WriteLine("Thursday");
        //        break;
        //    case 6:
        //        Console.WriteLine("Friday");
        //        break;
        //    case 7:
        //        Console.WriteLine("Saturday");
        //        break;

        //    default:
        //        Console.WriteLine("Enter a number from 1 to 7.");
        //        break;
        //}

        //int i = 1;


        //while (i < 3)


        //{
        //    Console.WriteLine($"Enter your friends name");
        //    string sName = Console.ReadLine();
        //    Console.WriteLine($"Hello {sName}");

        //    i++;
        //}

        // take user input and use while to add number in reverse like; if input 4 its output should be 4+3+2+1+0
        //int iAnumber;
        //int iSum = 0;
        //Console.WriteLine("Enter your number");
        //iAnumber = Convert.ToInt32(Console.ReadLine()); //user input number

        //while (iAnumber >= 0)
        //{

        //    //Console.WriteLine($"You have entered the number {iA}");
        //    iSum = iSum + iAnumber;
        //    iAnumber--;

        //}
        //Console.WriteLine($"The sum is: {iSum}");


        //// take number of loops from user input  and print(name,age address)
        //Console.WriteLine("Enter the Number of Loop:");
        //int iNoOfLoops;
        //iNoOfLoops= Convert.ToInt32(Console.ReadLine()); //user inputs number of loops to run

        //int i = 0;
        //while (i < iNoOfLoops)
        //{
        //    Console.WriteLine("Enter your name: ");
        //    string sName = Console.ReadLine();

        //    Console.WriteLine("Enter your Age: ");
        //    int iAge = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine($"The Name is {sName} and Age is {iAge}");
        //    i += 1;
        //}

        //do while loop

        //int iMinValue = 0;
        //int iInputVlue;
        //Console.WriteLine($"Enter the number of loops to run");
        //iInputVlue = Convert.ToInt32(Console.ReadLine());
        //do
        //{
        //    Console.WriteLine($"do while run {iInputVlue}");
        //    iInputVlue--;
        //} while (iInputVlue >= iMinValue);





        //Console.WriteLine($"Enter the Character between A - Z");
        //string sInputChar;
        //do
        //{

        //    Console.WriteLine($"Do you want to continue the code Y/N");
        //    sInputChar = Console.ReadLine();

        //} while (sInputChar == "Y" || sInputChar == "y");
        //Console.WriteLine("You cannot continue");


        //1. even number checker


        //do
        //{
        //    int iNumberChecker;
        //    Console.WriteLine("Enter a number to check whether it is even or not");
        //    iNumberChecker = Convert.ToInt32(Console.ReadLine());

        //    if (iNumberChecker % 2 == 0)
        //    {
        //        Console.WriteLine($"{iNumberChecker} is a even number");
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{iNumberChecker} is not a even number");

        //    }

        //} while (true);

        //2. count digits of the number and answer

        //int iDigit;
        //int iDigitCount = 0;
        //Console.WriteLine("Enter a number to check digit");
        //iDigit = Convert.ToInt32(Console.ReadLine());
        //do
        //{
        //    iDigit = iDigit / 10;
        //    iDigitCount++;  
        //}
        //while (iDigit != 0);
        //Console.WriteLine($"The digits of entered number are {iDigitCount}");




        //3. password checker


        //string sInputPass;

        //do
        //{
        //    Console.WriteLine($"Enter your password");
        //    sInputPass = Console.ReadLine();
        //    if (sInputPass == "abc123")
        //    {
        //        Console.WriteLine("You entered correct password");
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter the correct password");
        //    }
        //}
        //while (sInputPass != "abc123");
        int max = 5,sum = 0;
        for (int i = 1; i <= max; i++)
        {
            sum += 1;
        }
        Console.WriteLine($"Hello students, {sum}");


    }

}






