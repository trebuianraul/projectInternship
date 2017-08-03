using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    //Strategy 
    abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }

    class Grilling: CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }

    class OvenBaking: CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by baking it.");
        }
    }

    class CookingMethod
    {
        private string Food;
        private CookStrategy _cookstrategy;

        public void SetCookStrategy(CookStrategy cookStrategy)
        {
            this._cookstrategy = cookStrategy;
        }

        public void SetFood(string name)
        {
            Food = name;
        }

        public void Cook()
        {
            _cookstrategy.Cook(Food);
            Console.WriteLine();
        }
    }

}
