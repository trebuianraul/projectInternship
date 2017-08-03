using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    class Drink
    {
        private string _drink;
        private string _type;
        private int _ml;

        public Drink(string drink, string type, int ml)
        {
            _drink = drink;
            _type = type;
            _ml = ml;
        }
        public void Display()
        {
            Console.WriteLine("Choose a drink");
            Console.WriteLine();
            Console.WriteLine("Choose the type of the drink: {0}", _type);
            Console.WriteLine("Choose how big will be the drink: {0}", _ml);
        }
    }
}
