using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    abstract class IShop
    {
        public abstract void Display();
    }
    class Decorator : IShop
    {
        protected IShop _ishop;
        public Decorator(IShop ishop)
        {
            _ishop = ishop;
        }

        public override void Display()
        {
            _ishop.Display();
        }
    }

    class Nachos : IShop
    {
        private string _topping;
        private string _sauce;

        public Nachos(string topping, string sauce)
        {
            _topping = topping;
            _sauce = sauce;
        }

        public override void Display()
        {
            Console.WriteLine("Nachos");
            Console.WriteLine("Topping: {0} ", _topping);
            Console.WriteLine("Sauce: {0} ", _sauce);
        }
    }

    class Popcorn : IShop
    {
        private string _salt;
        private string _cheese;

        public Popcorn(string salt, string cheese)
        {
            _salt = salt;
            _cheese = cheese;
        }

        public override void Display()
        {
            Console.WriteLine("Popcorn");
            Console.WriteLine("Salt: {0}", _salt);
            Console.WriteLine("Cheese: {0}", _cheese);
        }
    }

    class ConcreteDecorator: Decorator
    {
        public int _number { get; set; }
        protected List<string> customers = new List<string>();

        public ConcreteDecorator(IShop ishop, int number): base(ishop)
        {
            _number = number;
        }

        public void Order(string name)
        {
            if(_number>0)
            {
                customers.Add(name);
                _number--;
            }
            else
            {
                Console.WriteLine("Not enough product for: " + name);
            }
        }

        public override void Display()
        {
            base.Display();
            foreach(var customer in customers)
            {
                Console.WriteLine("Ordered by: " + customer);
            }
        }
    }
}
