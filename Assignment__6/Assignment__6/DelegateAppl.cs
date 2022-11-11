using System;
using Assignment__6;

delegate int NumberChanger(int n);
namespace DelegateAppl
{

    class EmployeeDelegate
    {
        static int balance = 50000;

        public static int AddNum(int p)
        {
            balance += p;
            return balance;

        }
        public static int Withdraw(int q)
        {
            balance -= q;
            return balance;
        }
        public static int getNum()
        {
            return balance;
        }
        static void Main(string[] args)
        {
            EmployeeEntities emp = new EmployeeEntities();

            Console.WriteLine("Please Enter The Account Number : ");
            emp.account_number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter The Customer Name : ");
            emp.customer_name = Console.ReadLine();

            Boolean p = true;

            while (p)
            {
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("********************************Banking**********************************");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("\nPlease Press 1 To Deposit The Amount");
                Console.WriteLine("\nPlease Press 2 To Withdraw The Amount");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 1:

                        Console.Write("\nPlease Enter the Amount in Numbers to Deposit into {0} Account :  ", emp.customer_name);
                        emp.deposit_amount = int.Parse(Console.ReadLine());

                        NumberChanger Deposit = new NumberChanger(AddNum);

                        Deposit((int)emp.deposit_amount);

                        Console.WriteLine("\n----------------------------");
                        Console.WriteLine("\nNow Your Balance is: {0}", getNum());

                        break;

                    case 2:
                        Console.Write("\nPlease Enter the Amount You Want To Withdraw from {0} Account ", emp.customer_name);
                        emp.withdraw = int.Parse(Console.ReadLine());

                        NumberChanger withdraw = new NumberChanger(Withdraw);

                        withdraw((int)emp.withdraw);

                        Console.WriteLine("\n----------------------------");

                        int RemainingBalance = getNum();
                        if (RemainingBalance == 0)
                        {
                            Console.WriteLine("\nHi {0}", emp.customer_name);
                            Console.Write("\nYour Account Balance Becoming Zero for the selected Amount to Withdraw Kindly Enter the Amount Lesser than the Value ");
                            balance = 50000;
                        }
                        else if (RemainingBalance < 0)
                        {
                            Console.WriteLine("\nHi {0}", emp.customer_name);
                            Console.Write("\nYour Account Balance Becoming Becoming Negative for the selected Amount to Withdraw Kindly Enter the Amount Lesser than the Value ");
                            balance = 50000;
                        }
                        Console.WriteLine("\nNow Your Balance is: {0}", getNum());
                        break;

                }

                
            }
        }
    }
}