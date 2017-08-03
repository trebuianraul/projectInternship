using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class Movie: Film
    {
        
        
        public bool blockbuster;
        public void SearchingTitle(string title)
        {
            title = "A new world";
            Console.WriteLine("The title of the movie is: {0}", title);
            
            Console.ReadLine();
            Console.WriteLine("The movie's name starts with: 'A new' ");
            Console.WriteLine(title.StartsWith("A new"));
            Console.WriteLine("The movie's name ends with: 'new' ", title.EndsWith("new"));
            Console.WriteLine(title.EndsWith("new"));
            Console.WriteLine("The movie's name contains the word: 'world' ");
            Console.WriteLine(title.Contains("world"));
            Console.ReadLine();
        }

        public void FormattingTitle()
        {           
            string headline = "Inception {0} {1} {2} Leonardo Di Caprio.";
            string newTitle = string.Format(headline, "was", 1, "of the best movies for");
            string headline1 = "Movie1:{0,-24}    Main actor:{1,10}      Oscar winner:{2,3}";
            string newTitle1 = string.Format(headline1, " Out of the wild", " John Diehl", "No");
            string headline2 = "Movie2:{0, -15}    Main actor:{1,10}      Oscar winner:{2,3}";
            string newTitle2 = string.Format(headline2, " We'll Test It on Humans", "Michael Davis", "Yes");
            Console.WriteLine(newTitle);
            Console.WriteLine(newTitle1);
            Console.WriteLine(newTitle2);
            Console.ReadLine();
        }

        public void CompareTitle()
        {
            string title1 = "New Age";
            string title2 = "Cohnan";
            Console.WriteLine("Order ompare between " + title1 + " and " + title2);
            Console.WriteLine(string.Compare(title1, title2, StringComparison.InvariantCulture));
            Console.ReadLine();
        }

        public void MovieTime()
        {
            TimeSpan startingTime = new TimeSpan(21, 30, 00);
            TimeSpan endingTime = new TimeSpan(23, 05, 00);
            DateTime date1 = new DateTime(2017, 7, 24, 21, 30, 00);
            DateTime date2 = DateTime.Now;
            Console.WriteLine("We need to be at the cinema before: {0}", date1);
            Console.WriteLine("Now is: {0}", date2);
            Console.WriteLine("The movie will start at: {0}", startingTime);
            Console.WriteLine("The movie will end at: {0} ", endingTime);


            var dateTime = new DateTime(2017, 9, 21);
            Console.WriteLine(dateTime);
            DateTimeOffset offset = dateTime;
            Console.WriteLine(offset);

            DateTime utcDateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
            offset = utcDateTime;
            Console.WriteLine(offset);


            Console.ReadLine();
        }

        public void Price(string title, string country)
        {
            
            Console.WriteLine("The current price ticket for : " +title + " in " + country + " is "  +3.ToString("C", CultureInfo.CurrentCulture));
            CultureInfo dk = new CultureInfo("da-DK");
            Console.WriteLine("The same ticket for : " + title + " in " + country + " is " + 10.ToString("C", dk));           
            Console.ReadLine();

        }

        public void Record(string title)
        {
            Console.WriteLine("The time for recording is: " + title + "days");
        }

        public void ListMovies()
        {
            List<string> moviesList = new List<string>();
            moviesList.Add("Movie 1");
            moviesList.Add("Movie 2");
            moviesList.Add("Movie 3");
            foreach(var movies in moviesList)
            {
                Console.WriteLine(movies);
            }
            Console.ReadLine();
        }
    }
}
