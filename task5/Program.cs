using System;
using task5;

class Program
{
   
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if (User.Login(username, password))
            {
                Console.WriteLine("Login successful!");
            }
            else if (!User.Login(username, password))
                {
                    Console.WriteLine("Login failed!");
                    return;
                }


            Console.WriteLine("What will you choose? \n " + "1 = In Travel \n " + "2 = Out Travel");
            string choose = Console.ReadLine();
            if (choose == "1")
            {
                Console.WriteLine("Enter the transportation:");
                string transportation = Console.ReadLine();
                Console.WriteLine("Enter the travel number:");
                int travelNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the from date:");
                DateTime fromDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of days:");
                int noOfDays = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the destination:");
                string destination = Console.ReadLine();
                Console.WriteLine("Enter the price:");
                int price = int.Parse(Console.ReadLine());


                InTravel inTravel = new InTravel
                {
                    Transportation = transportation,
                    Travelnum = travelNo,
                    Fromdata = fromDate,
                    Num_ofdays = noOfDays,
                    Destination = destination,
                    Price = price
                };
                Console.WriteLine("InTravel:");
                Console.WriteLine(inTravel.Details());

            }
            else if (choose == "2")
            {
                Console.WriteLine("What will you choose? \n " + "1 = Rel Travel \n " + "2 = Fun Travel");
                string Choose = Console.ReadLine();
                if (Choose == "1")
                {
                    Console.WriteLine("Enter the path:");
                    string path = Console.ReadLine();

                    Console.WriteLine("Enter the transportation:");
                    string transportation = Console.ReadLine();
                    Console.WriteLine("Enter the travel number:");
                    int travelNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the from date:");
                    DateTime fromDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the number of days:");
                    int noOfDays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the destination:");
                    string destination = Console.ReadLine();
                    Console.WriteLine("Enter the price:");
                    int price = int.Parse(Console.ReadLine());


                    RelTravel relTravel = new RelTravel
                    {
                        Airline = transportation,
                        Travelnum = travelNo,
                        Fromdata = fromDate,
                        Num_ofdays = noOfDays,
                        Destination = destination,
                        Price = price,
                        Path = path
                    };

                    Console.WriteLine("RelTravel:");
                    Console.WriteLine(relTravel.Details());
                }
                else if (Choose == "2")
                {
                    Console.WriteLine("Is visa required?");
                    bool isVisa = bool.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the transportation:");
                    string transportation = Console.ReadLine();
                    Console.WriteLine("Enter the travel number:");
                    int travelNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the from date:");
                    DateTime fromDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the number of days:");
                    int noOfDays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the destination:");
                    string destination = Console.ReadLine();
                    Console.WriteLine("Enter the price:");
                    int price = int.Parse(Console.ReadLine());



                    FunTravel funTravel = new FunTravel
                    {
                        Airline = transportation,
                        Travelnum = travelNo,
                        Fromdata = fromDate,
                        Num_ofdays = noOfDays,
                        Destination = destination,
                        Price = price,
                        IsVisa = isVisa
                    };

                    Console.WriteLine("FunTravel:");
                    Console.WriteLine(funTravel.Details());
                }
            }
        
            Console.ReadLine();
            Console.ReadKey();
        }
}