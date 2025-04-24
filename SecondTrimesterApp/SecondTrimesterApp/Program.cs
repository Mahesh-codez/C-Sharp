using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Enter you name");
        //string name; // declaration
        //name = Console.ReadLine();
        //Console.WriteLine("The name is: " + name);





        ////Console.WriteLine("Hello, World!");

        //Char myCcar = 'A';
        //Console.WriteLine(myCcar);

        //int age = 8;
        //Console.WriteLine(age);

        //string myName = "mahesh";
        //Console.WriteLine(name);

        //bool hello = true;
        //Console.WriteLine(hello);

        //double abc = 12.33;
        //Console.WriteLine(abc);

        //float xyz = 12.334343f;
        //Console.WriteLine(xyz);

        //decimal fgh = 12;
        //Console.WriteLine(fgh);

       // NameMessage();
        ArrayFunction();
        KaaliFunction();

    }


    //private static void ErrorFunction()
    //{
    //    ////missing semicolon error
    //    //Console.WriteLine("I am error 1") //compiler error
    //    //     console.Writeline("I am error 2"); // syntax error

    //    //// runtime error
    //    //int input1 = 9;

    //    //int input2 = 0;
    //    //int division = input1 / input2;

    //    //Console.WriteLine(division);

    //    //string fruitName = null;
    //    //Console.WriteLine(fruitName.Length);

    //}

    //private static void NameMessage()
    //{
    //    //    take user input
    //    //string hmw = firstname,lastname, age, address, (12th college name, address)

    //    Console.WriteLine("---Enter your Details---\n");

    //    Console.WriteLine("Enter your firstname");
    //    string firstName1;
    //    firstName1 = Console.ReadLine();

    //    Console.WriteLine("Enter your lastname");
    //    string lastName1;
    //    lastName1 = Console.ReadLine();

    //    Console.WriteLine("Enter your age");
    //    int age1;
    //    age1 = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("Enter your address");
    //    string address1;
    //    address1 = Console.ReadLine();

    //    Console.WriteLine("Enter your college name");
    //    string collegeName;
    //    collegeName = Console.ReadLine();

    //    Console.WriteLine("Enter your college address\nnn");
    //    string collegeAddress;
    //    collegeAddress = Console.ReadLine();



    //    Console.WriteLine($"The name is {firstName1} {lastName1}. Age is {age1}. Location is {address1}. College name is {collegeName} and college is located in {collegeAddress}\n\n\n");

    //    int roomNO;
    //    Console.WriteLine("Enter customer room no.");
    //    roomNO = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("Enter customer name");
    //    string customer = Console.ReadLine();

    //    Console.WriteLine($"Email address is: {roomNO}{customer}@gmail.com");
    //}
    private static void ArrayFunction()
    {
        //int[] number = { 1, 2, 3 };
        //string[] stringArray = { "Mahesh", "Dhiraj", "Anil" };
        //Console.WriteLine($"{number[1]}. {stringArray[1]}");

        //int[,] matrix = { { 1, 4, 2, 100 }, { 3, 6, 8, 200 }, { 20, 30, 40, 300 } };
        //Console.WriteLine(matrix[0, 1] + 36);
        //Console.WriteLine(matrix[1, 2]);
        //Console.WriteLine(matrix[2, 0]);


        // array with 3 rows and 3 coloumns
        //int[,] iarr = new int[3, 3];

        //Console.WriteLine("Enter the value for iarr[0,0]: ");
        //iarr[0, 0] = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value for iarr[0,1]: ");
        //iarr[0, 1] = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value for iarr[0,2]: ");
        //iarr[0, 2] = Convert.ToInt32(Console.ReadLine());
        

        //Console.WriteLine("Enter the value for iarr[1,0]: ");
        //iarr[1, 0] = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value for iarr[1,1]: ");
        //iarr[1, 1] = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value for iarr[1,2]: ");
        //iarr[1, 2] = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter iarr[2,0]: ");
        //iarr[2, 0] = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter iarr[2,1]: ");
        //iarr[2, 1] = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter iarr[2,2]: ");
        //iarr[2, 2] = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine($"{iarr[0, 0]} {iarr[0, 1]} {iarr[0, 2]}");
        //Console.WriteLine($"{iarr[1, 0]} {iarr[1, 1]} {iarr[1, 2]}");
        //Console.WriteLine($"{iarr[2, 0]} {iarr[2, 1]} {iarr[2, 2]}");

        // Third day of array
        //int[] inumberArr = { 10, 20, 30, 11,5 };
        //int[,] matrix = { { 1, 4, 2, 100 }, { 3, 6, 8, 200 }, { 20, 30, 40, 300 } };
        ////Console.WriteLine(inumberArr.Rank);
        ////Console.WriteLine(matrix.Rank);
        //Array.Sort(inumberArr);
        //Console.WriteLine(inumberArr[0]);
        //Console.WriteLine(inumberArr[1]);
        //Console.WriteLine(inumberArr[2]);
        //Console.WriteLine(inumberArr[3]);

        //Array.Clear(inumberArr);
        //Array.Reverse(inumberArr);
    }
    private static void KaaliFunction()
    {
        // int iage;
        // Console.WriteLine("Please Enter your Age: ");
        // string user = Console.ReadLine();
        //iage = Convert.ToInt32(user);


        // if (iage >= 18 && iage< 60)
        // {
        //     Console.WriteLine("you can drive. Let's go to Arghakhanchi");
        // }
        // else if (iage >= 60)
        // {
        //     Console.WriteLine("Go to sleep. You cannot go to club");
        // }
        // else
        // {
        //     Console.WriteLine("you cannot drive.");
        // }


        //Console.WriteLine("Please Enter your Worktime: ");
        //int iWork = Convert.ToInt32(Console.ReadLine());
        //int iWorkNormal;
        //double dWorkOvertime;
        //double totalSalary;
        //if (iWork > 8 ) // for overtime work salary calculation
        //{
        //    dWorkOvertime = (iWork - 8) * 1.5;
        //    iWorkNormal = iWork * 1;
        //    totalSalary = dWorkOvertime + iWorkNormal;
        //    Console.WriteLine($"Your overtime salary is   : {dWorkOvertime}$");
        //    Console.WriteLine($"Your normal salary is: {iWorkNormal}$");
        //    Console.WriteLine($"Total salary is: {totalSalary}$");   
        //}
        //else //if (iWork <= 8) // normal working hour salary
        //{
        //    iWorkNormal = iWork * 1;
        //    Console.WriteLine($"Your normal salary is {iWorkNormal}$");
        //}


        int iwork; // declaring variable
        Console.Write(" Enter your worktime = ");
        iwork = Convert.ToInt32(Console.ReadLine());
        int iPerDay = 0;
        double dOverTime = 0;
        double dtotalSalary = 0;


        if (iwork >= 1)
        {
            //calculation of per day
            if (iwork <= 1)
            {
                iPerDay = iwork * 1;
            }
            else
            {
                iPerDay = 8 * 1;
            }
            //calculation of overtime
            if (iwork >= 9)
            {
                dOverTime = (iwork - 8) * 1.5;
            }

            dtotalSalary = iPerDay + dOverTime;
            Console.WriteLine($" Total salary is {dtotalSalary}");
        }
        else
        {

            Console.WriteLine("Not eligible for the salary");
        }


        const double dTipRate = 0.15; // 15% = 0.15
        const int iMinimumTip = 1; // fixed value
        double dTip;
        Console.WriteLine("Enter the bill amount");
        double dBillAmount  = Convert.ToDouble(Console.ReadLine());

        dTip = dBillAmount * dTipRate;

        if (dTip<iMinimumTip)
        {
            dTip = iMinimumTip;

        }
        Console.WriteLine($"The bill amount is: {dBillAmount}");

        Console.WriteLine($"The tip is: {dTip}");


        //string sName = "";
        //Console.Write("Enter your name = ");
        //sName = Console.ReadLine();
        //int iStudentPercentage;
        //Console.Write("Enter your marks = ");
        //iStudentPercentage = Convert.ToInt32(Console.ReadLine());
        //string sStudentGrade = (iStudentPercentage >= 90) ? "A Grade" : (iStudentPercentage >= 80) ? "B Grade" : (iStudentPercentage >= 70) ? "C Grade" : (iStudentPercentage >= 60) ? "D Grade" : (iStudentPercentage >= 50) ? "E Grade" : "Fail";
        //Console.WriteLine($"{sName} has achieved {iStudentPercentage}% and is awarded with {sStudentGrade}.");

        //Console.ReadKey();

        Console.WriteLine("Please Enter your percentage: ");
        int percentAge = Convert.ToInt32(Console.ReadLine());

        if (percentAge >= 90 && percentAge <= 100)
        {
            //Console.WriteLine("you got A");
            if (percentAge >= 96 && percentAge <= 100)
            {
                Console.WriteLine("you got A+");
            }
            else
            {
                Console.WriteLine("you got A");
            }
        
         if (percentAge >= 80 && percentAge<= 95)
        {
            Console.WriteLine("you got B");
        }
            
         if (percentAge >= 70)
            {
                Console.WriteLine("you got C ");
            }
            else if (percentAge >= 60)
            {
                Console.WriteLine("you got C+");
            }
            else if (percentAge >= 50)
            {
                Console.WriteLine("you got C");
            }
            else
            {
                Console.WriteLine("you are fail");
            }


    }
}



