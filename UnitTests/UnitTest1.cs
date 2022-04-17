using CoffeeVendingMachineApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckIfInstanceIsNull()
        {
            VendingMachine vendingMachine = new VendingMachine();
            ICoffeeBuilder coffeeService= new CoffeBuilder("Americano",new CoffeeService());
            vendingMachine.MakeCoffee(coffeeService, new Ingredients(1, 2, 1, 1, 1));

            Assert.IsNotNull(coffeeService.GetCoffee);
        }
        [TestMethod]
        public void CheckIfRightIngredientsAreApplied()
        {
            VendingMachine vendingMachine = new VendingMachine();
            ICoffeeBuilder coffeeService = new CoffeBuilder("Americano", new CoffeeService());
            vendingMachine.MakeCoffee(coffeeService, new Ingredients(1, 2, 1, 1, 1));
            bool condition =
                coffeeService.GetCoffee.dosesOfMilk == 1
                && coffeeService.GetCoffee.cupsOfCoffee == 2
                && coffeeService.GetCoffee.caramel == 1
                && coffeeService.GetCoffee.creamer == 1
                && coffeeService.GetCoffee.cupsOfSugar == 1;
            Assert.IsTrue(condition);
        }
        [TestMethod]
        public void CheckIfRightInstanceIsCreated()
        {
            VendingMachine vendingMachine = new VendingMachine();
            ICoffeeBuilder coffeeService= new CoffeBuilder("Latte", new CoffeeService());
            vendingMachine.MakeCoffee(coffeeService, new Ingredients(1, 2, 1, 1, 1));
            Assert.IsInstanceOfType(coffeeService.GetCoffee, typeof(Latte));
        }
    }
}
