using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachineApp
{
    public class VendingMachine
    {
        public void MakeCoffee(ICoffeeBuilder builder)
        {
            builder.PrepareCoffee();
        }
        public void MakeCustomCoffee(ICoffeeBuilder builder, Ingredients ingridients)
        {
            builder.PrepareCoffee(ingridients);
        }
    }
}
