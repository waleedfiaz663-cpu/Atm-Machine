using System;

class Program
{
    static void Main()
    {

        String CorrectPin = "1234";
        int DailyLimit = 50000;
        int WithDrawToday = 0;

        Console.WriteLine("=======================");
        Console.WriteLine("     WELCOME TO ATM    ");
        Console.WriteLine("=======================");
        Console.WriteLine();


        Console.WriteLine("Please Enter Your Card Number : ");
        string cardnumber = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Card Accepted");

        Console.WriteLine();

        string pin;

        while (true)
        {
            Console.WriteLine("Please Enter Your Pin : ");
            pin = Console.ReadLine();

            if (pin == CorrectPin)
            {
                Console.WriteLine();
                Console.WriteLine("Pin Is Correct");
                break;
            }

            else
            {
                Console.WriteLine("Wrong Pin, Please Try Again");
            }
        }


        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("      Atm Main Menu     ");
            Console.WriteLine("========================");
            Console.WriteLine();
            Console.WriteLine("1. 100");
            Console.WriteLine("2. 500");
            Console.WriteLine("3. 1000");
            Console.WriteLine("4. 5000");
            Console.WriteLine("5. 10000");
            Console.WriteLine("6. Other Amount");
            Console.WriteLine("7. Exit");
            Console.WriteLine();

            Console.Write("Please Select An Option : ");
            string choice = Console.ReadLine();

            int amount = 0;

            if (choice == "1")
            {
                amount = 100;
            }

            else if (choice == "2")
            {
                amount = 500;
            }

            else if (choice == "3")
            {
                amount = 1000;
            }

            else if (choice == "4")
            {
                amount = 5000;
            }

            else if (choice == "5")
            {
                amount = 10000;
            }

            else if (choice == "6")
            {
                Console.WriteLine();

                Console.Write("Please Enter The Amount You Want To WithDraw : ");
                amount = Convert.ToInt32(Console.ReadLine());
            }

            else if (choice == "7")
            {
                Console.WriteLine();
                Console.WriteLine("Please Take Your Card");
                Console.WriteLine();
                Console.WriteLine("Thank You For Using The Atm");
                break;
            }

            else
            {
                Console.WriteLine("Invalid Option,Please Try Again");
                continue;
            }

            if (amount < 0)
            {
                Console.WriteLine("Invalid Amount");
                continue;
            }

            if (WithDrawToday + amount > DailyLimit)
            {
                int remainingamount = DailyLimit - WithDrawToday;

                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine();
                Console.WriteLine("You Cannot Wuthdraw This Amount");
                Console.WriteLine();
                Console.WriteLine("your Daily Limit Is Rs 50,000");
                Console.WriteLine();
                Console.WriteLine("You Can Withdraw Upto Rs " + remainingamount + "today");
                Console.WriteLine();
                Console.WriteLine("=================================");
                continue;
            }

            WithDrawToday = WithDrawToday + amount;

            Console.WriteLine();
            Console.WriteLine("PLease Wait");
            Console.WriteLine();
            Console.WriteLine("Your Cash Is Being Processed");
            Console.WriteLine();
            Console.WriteLine("Please Take Your Cash: Rs" +amount);


            Console.WriteLine();
            Console.WriteLine("Would You Like A Receipt?");
            Console.WriteLine("1. Go Green");
            Console.WriteLine("2. Print Rceipt");
            Console.WriteLine();

            Console.WriteLine("Select An Option:");
            string receiptchoice = Console.ReadLine();


            if (receiptchoice == "1")
            {
                Console.WriteLine("Go Green Selected");
            }

            else if (receiptchoice == "2")
            {
                Console.WriteLine("==============================================");
                Console.WriteLine();
                Console.WriteLine("           ======RECEIPT========         ");
                Console.WriteLine();
                Console.WriteLine("WithDrawl: Rs" + amount);
                Console.WriteLine();
                Console.WriteLine("WithDrawlToday: Rs" + WithDrawToday);
                Console.WriteLine();
                Console.WriteLine("RemainingAmount:" + (DailyLimit-WithDrawToday));
                Console.WriteLine();
                Console.WriteLine("==============================================");

            }

            else
            {
                Console.WriteLine("Invalid Option");
            }

            Console.WriteLine();

            Console.WriteLine("Do You Want Another Transaction(Y/N)");
            string again = Console.ReadLine();

            if (again.ToUpper() == "N")
            {
                break;
            }

        }

        Console.WriteLine();
        Console.WriteLine("===============================");
        Console.WriteLine();
        Console.WriteLine("Please take Your Card");
        Console.WriteLine();
        Console.WriteLine("Thank You For Using The Atm");
        Console.WriteLine();
        Console.WriteLine("Have A Nice Day");
        Console.WriteLine();
        Console.WriteLine("===============================");
        Console.ReadLine();
    }
}