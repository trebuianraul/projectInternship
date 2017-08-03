using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    [TestFixture]
    class TestClass
    {
        private string _name;
        private int _money;
        [Test]
        public void Name(string name)
        {
            _name = name;
        }

        public void Money(int money)
        {
            _money = money;
        }

    }
}
