using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachineApp
{
    public class Ingredients
    {
        public int dosesOfMilk { get; set; }
        public int cupsOfSugar { get; set; }
        public int cupsOfCoffee { get; set; }
        public int caramel { get; set; }
        public int creamer { get; set; }

        public Ingredients()
        {

        }
        public Ingredients(int dosesMilk, int cupsCoffee, int crml, int cream, int cupsSugar)
        {
            dosesOfMilk = dosesMilk;
            caramel = crml;
            cupsOfCoffee = cupsCoffee;
            creamer = cream;
            cupsOfSugar = cupsSugar;
        }
        public void Deconstruct(out int dosesMilk, out int crml, out int cupsCoffee, out int cream, out int cupsSugar)
        {
            dosesMilk = dosesOfMilk;
            crml = caramel;
            cupsCoffee = cupsOfCoffee;
            cream = creamer;
            cupsSugar = cupsOfSugar;

        }
    }
}
