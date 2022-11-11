namespace ConsoleApplication1
{
    class Q2
    {
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }


        public static void Main(string[] args)
        {


            string pathString = @"C:\Ayesha\Training\Assignment__7\Assignment__7\CustomerDetails.txt";

            Boolean p = true;

            while (p)
            {
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("****************************Customer Details*****************************");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("1)Add Customer Details into a text file");
                Console.WriteLine("2)Dispaly Customer Details from a text file");


                int option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        Customer CustomerDetail = new Customer();

                        Console.Write("Customer Id:");
                        CustomerDetail.Id = int.Parse(Console.ReadLine());

                        Console.Write("Customer Name:");
                        CustomerDetail.Name = Console.ReadLine();

                        Console.Write("Customer Address:");
                        CustomerDetail.Address = Console.ReadLine();
                        using (StreamWriter w = File.AppendText("C:\\Ayesha\\Training\\Assignment__7\\Assignment__7\\CustomerDetails.txt"))
                        {
                            w.WriteLine("Id: " + CustomerDetail.Id + Environment.NewLine + "Customer Name: " + CustomerDetail.Name + Environment.NewLine + "Customer Address: " + CustomerDetail.Address);
                            w.Flush();
                        }
                        break;

                    case 2:
                        TextReader tr = new StreamReader(@"C:\Ayesha\Training\Assignment__7\Assignment__7\CustomerDetails.txt");

                        Console.WriteLine(tr.ReadLine());
                        Console.WriteLine(tr.ReadToEnd());
                        tr.Close();
                        break;
                }
            }
        }
    }

}