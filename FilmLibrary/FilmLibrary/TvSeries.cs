using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class TvSeries: Film
    {
        public string season;
        public string episode;
        public List<string> list;

        public void Lista()
        {
            list = new List<string>();
            list.Add("item");
            foreach (var i in list) 
            Console.WriteLine(i);
        }

        public TvSeries()
        {
            title = "Breaking Bad";
            Console.WriteLine("The Tv Series choosens is: " + title);
        }
    }
}
