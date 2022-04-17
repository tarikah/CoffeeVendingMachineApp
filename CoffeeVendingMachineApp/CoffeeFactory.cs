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
         void PrepareCoffee(Ingredients ingredients);
        Coffee GetCoffee { get; }
    }
   
    public class CoffeBuilder : ICoffeeBuilder
    {
        Coffee Coffee;
        public CoffeBuilder(string coffeeType, ICoffeService _coffeeService)
        {
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
        public void PrepareCoffee(Ingredients ingredients)
        {
            Coffee.PrepareIngridients(ingredients);
        }

    }
}
