using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public abstract class Film
    {
       
        public string title;
        string genre;
        public string description;
        public string runningtime;
        public string awards;
        
        public string review;
        public string language;
        public string country;
        public int year;
        public static DateTime releasedate;
        static DateTime registrationdate;
        private static DayOfWeek dayOfWeek;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName() => FirstName + LastName;

        public string getTitle()
        {
            return title;
        }
    
        static Film()
        {
            registrationdate = DateTime.Now;
            dayOfWeek = DateTime.Now.DayOfWeek;          
            Console.WriteLine("Today is: {0, -7} {1, 5}", dayOfWeek, registrationdate);
            Console.ReadLine(); 
        }    
           
        public void ShowTitle(string title)
        {
            
            if(title == null)
            {
                throw new Exception(nameof(title) + " is null");
            }
            Console.ReadLine();
        }
    
        public void ShowCast(string name, string position, int age =25, bool awards = false)
        {
            Console.WriteLine(name);
            Console.WriteLine(position);
            Console.WriteLine(age);
            Console.WriteLine(awards);
            Console.ReadLine();
        }

        //optional parameter&named argument
        public void Review(string title, int rating=5)
        {
            try
            {
                Console.WriteLine(title + " is rated with " + rating + " stars.");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception caught: {0} ", e);
            }
            Console.ReadLine();
        }

        //dynamic
        public void ListWithMovies()
        {
            dynamic values = new List<string> {"The Lost City of Z", "Moana", "Rogue One" };
            dynamic valueToAdd = ", "; 
            Console.WriteLine("List with movies");
            Console.ReadLine();
            foreach(dynamic i in values)
            {
                string result = i + valueToAdd;
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        //string interpolation
        public void DescriptionMovie(string description, string title)
        {
            title = "Inception";
            description = "is one of the most amazing movies in history.";
            Console.Write($"{title} {description}");
            Console.ReadLine();
        }
    }
}
