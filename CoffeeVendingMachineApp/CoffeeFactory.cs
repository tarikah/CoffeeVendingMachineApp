using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachineApp
{
    public interface ICoffeeBuilder
    {
         void PrepareCoffee();
         void PrepareCoffee(Ingredients ingridients);
        Coffee GetCoffee { get; }
    }
   
    public class CoffeBuilder : ICoffeeBuilder
    {
        Coffee Coffee;
        ICoffeService _coffeeService;
        public CoffeBuilder(string coffeeType)
        {
            _coffeeService = new CoffeeService();

            Coffee = _coffeeService.GetTypeOfCoffee(coffeeType);
        }
        public Coffee GetCoffee
        {
            get { return Coffee; }
        }
        public void PrepareCoffee()
        {
            Coffee.PrepareIngridients();
        }
        public void PrepareCoffee(Ingredients ingridients)
        {
            Coffee.PrepareIngridients(ingridients);
        }

    }
}
