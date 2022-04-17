using CoffeeVendingMachineApp.DbData;
using CoffeeVendingMachineApp.DbServices;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoffeeVendingMachineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----Select from Vending Machine service function---");
            Console.WriteLine("Get coffee from 3rd party services - 1");
            Console.WriteLine("Get basic coffee with predefined ingredients - 2");
            Console.WriteLine("Decorate or Customize basic coffee - 3");

            Console.WriteLine("NOTE :If you select 1 THE API SERVICE MUST BE RUNNING!!---");
            var selectedService=Console.ReadLine();
            if (selectedService == "1")
            {
                

                Console.WriteLine("----Select 3rd party list of coffees---");

                IDbDataService db = new DbDataService();

                var listOfCoffees = db.GetCoffeesFromDB().Result;

                foreach (var item in listOfCoffees)
                {
                    Console.WriteLine($"{item.name} - {item.id}");
                }

                var _coffeeId = Convert.ToInt32(Console.ReadLine());

                var ingredients = db.GetIngredientsFromDb(_coffeeId).Result;

                Console.WriteLine(listOfCoffees.Find(x => x.id == _coffeeId).name);
                Console.WriteLine("Made Of:");
                foreach (var item in ingredients)
                {

                    Console.WriteLine($"{item.name}");
                }
                System.Environment.Exit(0);
            }




            //---------------------------------------------------------------------------------------

            if (selectedService == "2")
            {
                VendingMachine vendingMachine = new VendingMachine();


                Console.WriteLine("----Select from predefined coffees---");
                Console.WriteLine("(Americano,Latte,Espresso,Machiato,Capuccino)");
                var _coffee = Console.ReadLine();

                Console.WriteLine("Preparing...");

                ICoffeeBuilder coffeeService = new CoffeBuilder(_coffee, new CoffeeService());
                vendingMachine.MakeCoffee(coffeeService);

                Console.WriteLine(coffeeService.GetCoffee.ToString());

                System.Environment.Exit(0);
            }



            //---------------------------------------------------------------------------------------


            if (selectedService == "3")
            {
                VendingMachine vendingMachine = new VendingMachine();

                Console.WriteLine("----Customize or decorate coffee---");
                Console.WriteLine("HINT: if you want to create unique coffee enter Custom");
                var coffee = Console.ReadLine();
                Console.WriteLine("Milk");
                var milk = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Coffee");
                var cupsCoffe = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sugar");
                var sugar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Creamer");
                var creamer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Caramel");
                var caramel = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Preparing...");

                ICoffeeBuilder coffeeService = new CoffeBuilder(coffee, new CoffeeService());
                vendingMachine.MakeCoffee(coffeeService, new Ingredients(milk, cupsCoffe, caramel, creamer, sugar));

                Console.WriteLine(coffeeService.GetCoffee.ToString());

                System.Environment.Exit(0);
            }
        }
    }
}
