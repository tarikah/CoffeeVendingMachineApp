using System;

namespace CoffeeVendingMachineApp
{
    internal class Program
    {
      
         static void Main(string[] args)
        {
            VendingMachine vendingMachine=new VendingMachine();
           


            Console.WriteLine("----Select from predefined coffees---");
            Console.WriteLine("(Americano,Latte,Espresso,Machiato,Capuccino)");
            var _coffee = Console.ReadLine();

            Console.WriteLine("Preparing...");

            ICoffeeBuilder coffeeService = new CoffeBuilder(_coffee);
            vendingMachine.MakeCoffee(coffeeService);

            Console.WriteLine(coffeeService.GetCoffee.ToString());



//---------------------------------------------------------------------------------------




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

            coffeeService=new CoffeBuilder(coffee);
            vendingMachine.MakeCustomCoffee(coffeeService, new Ingredients(milk, cupsCoffe, caramel, creamer, sugar));

            Console.WriteLine(coffeeService.GetCoffee.ToString());
        }
    }
}
