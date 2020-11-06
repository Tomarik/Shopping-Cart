using System;

namespace Shopping_Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            string userSelection = "";
            Shipper CustomerCart = new Shipper();
            Bike bike = new Bike();
            Crackers crackers = new Crackers();
            Glove glove = new Glove();
            Mower mower = new Mower();



            while (userSelection != "6")
            {


                System.Console.WriteLine("Choose from the following options: \n");
                System.Console.WriteLine("1. Add a Bicycle to shipment");
                System.Console.WriteLine("2. Add a Lawn Mower to the shipment");
                System.Console.WriteLine("3. Add a Baseball Glove to the shipment");
                System.Console.WriteLine("4. Add a Crackers to shipment");
                System.Console.WriteLine("5. List Shipment Items");
                System.Console.WriteLine("6. Compute Shipping Charges \n");

                userSelection = Console.ReadLine();

                if (userSelection == "1")
                {
                    System.Console.WriteLine(" \n1 Bicycle has been added");
                    System.Console.WriteLine("Press any key to return to menu\n");
                    CustomerCart.Add(bike);
                    Console.ReadKey();

                }

                if (userSelection == "2")
                {
                    System.Console.WriteLine(" \n1 Baseball Glove has been added");
                    System.Console.WriteLine("Press any key to return to menu\n");
                    CustomerCart.Add(glove);
                    Console.ReadKey();
                }

                if (userSelection == "3")
                {
                    System.Console.WriteLine(" \n1 Lawn Mower has been added");
                    System.Console.WriteLine("Press any key to return to menu\n");
                    CustomerCart.Add(mower);
                    Console.ReadKey();
                }

                if (userSelection == "4")
                {
                    System.Console.WriteLine(" \n1 Crackers has been added");
                    System.Console.WriteLine("Press any key to return to menu\n");
                    CustomerCart.Add(crackers);
                    Console.ReadKey();
                }

                if (userSelection == "5")
                {
                    CustomerCart.OutputList();
                    System.Console.WriteLine("\nPress any key to return to menu\n");
                    Console.ReadKey();
                }
                Console.Clear();

            }
            System.Console.WriteLine("Total shipping cost for this order is $" + CustomerCart.ShippingCost());
            System.Console.WriteLine("Press any key to exit program");
            System.Console.ReadKey();
        }
    }
}
