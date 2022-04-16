using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendingMachineApp
{
    public class Coffee
    {
        public int dosesOfMilk { get; set; }
        public int cupsOfSugar { get; set; }
        public int cupsOfCoffee { get; set; }
        public int caramel { get; set; }
        public int creamer { get; set; }

        public virtual void PrepareIngridients(Ingredients ingridients)
      => (dosesOfMilk, caramel, cupsOfCoffee, creamer, cupsOfSugar) = ingridients;

        public virtual void PrepareIngridients()
        {

        }
        public override string ToString()
        {
            return String.Format("Selected coffee: {0}\n\n dosesOfMilk - {1}\n cupsOfSugar - {2}\n cupsOfCoffee - {3}\n caramel - {4}\n creamer - {5}",
                this.GetType().Name, dosesOfMilk, cupsOfSugar, cupsOfCoffee, caramel, creamer);
        }


    }

    public class Espresso : Coffee
    {

        public override void PrepareIngridients()
        => (dosesOfMilk, caramel, cupsOfCoffee, creamer, cupsOfSugar) = (1, 2, 0, 0, 3);
    }
    public class Latte : Coffee
    {
        public override void PrepareIngridients()
         => (dosesOfMilk, caramel, cupsOfCoffee, creamer, cupsOfSugar) = (1, 2, 0, 0, 3);
    }
    public class Machiato : Coffee
    {
        public override void PrepareIngridients()
         => (dosesOfMilk, caramel, cupsOfCoffee, creamer, cupsOfSugar) = (1, 2, 0, 0, 3);
    }

    public class Americano : Coffee
    {
        public override void PrepareIngridients()
         => (dosesOfMilk, caramel, cupsOfCoffee, creamer, cupsOfSugar) = (1, 2, 0, 0, 3);
    }
    public class Capuccino : Coffee
    {
        public override void PrepareIngridients()
         => (dosesOfMilk, caramel, cupsOfCoffee, creamer, cupsOfSugar) = (1, 2, 0, 0, 3);

    }
}
