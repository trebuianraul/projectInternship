using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    // Singleton - Creational Design Pattern
    public sealed class Bell
    {
        private static Bell instance;
        private static readonly object padlock = new object();
        private Bell()
        {

        }

        public static Bell Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(padlock)
                    {
                        if (instance == null)
                            instance = new Bell();
                    }
                }
                return instance;
            }
        }

        public void Ring()
        {
            Console.WriteLine("Ring ring, someone is here");
        }
    }
}
