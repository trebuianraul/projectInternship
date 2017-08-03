using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{

    interface ISeller
    {
        void Ring();
    }
    class DependencyInjection
    {
        private ISeller _iseller;
        public DependencyInjection(ISeller iseller)
        {
            _iseller = iseller;
        }

        public void Call()
        {
            this._iseller.Ring();
        }
    }
}
