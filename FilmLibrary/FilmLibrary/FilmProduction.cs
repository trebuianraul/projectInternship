using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public static class FilmProductionFactory
    {
        public static Film CreateTvSeries()
        {
            return new TvSeries();
        }

        public static Film CreateMovie()
        {        
            return new Movie();
        }
    }
}
