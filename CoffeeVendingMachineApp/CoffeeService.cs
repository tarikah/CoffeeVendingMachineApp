using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachineApp
{
    public interface ICoffeService
    {
        Coffee GetTypeOfCoffee(string type);
    }
    public class CoffeeService : ICoffeService
    {
        public Coffee GetTypeOfCoffee(string type)
        {
            var typeOfCoffee = Type.GetType($"{typeof(Coffee).Namespace}.{type}");
            return (typeOfCoffee is null) ? new Coffee() : Activator.CreateInstance(typeOfCoffee) as Coffee;
        }
    }
}
