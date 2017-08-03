using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class Actors
    {
        private int _age { get; set; }
        private string _role { get; set; }
        private string _firstName { get; set; }
        private string _lastName;
        private string _contactinfo;
        private string _credits;
        private string _birthPlace;
        
        private bool _oscarWinner;
        private string _knownForMovie;
        private List<string> moviesPlayed = new List<string> { "ab", "bc" };
        private DateTime birthday;

        private string Fullname =>_firstName + " " + _lastName;
  
        public Actors()
        {

        }

        public void ActorsList()
        {
            List<Actors> actorsList = new List<Actors>();
            {
                actorsList.Add(new Actors() { _firstName = "Robert", moviesPlayed = new List<string> { "aa", "bb" }, birthday = new DateTime(1943, 8, 13) , _lastName = "De Niro", _birthPlace = "New York", _role = "jumper", _age = 74, _contactinfo = "https://www.celebrity.co.uk/page-celebrity-categories/robert-de-niro/", _knownForMovie = "Goodfellas", _oscarWinner = true });
                actorsList.Add(new Actors() { _firstName = "Jack", _lastName = "Nicholson", _age = 80, _role = "", _contactinfo = "https://www.celebrity.co.uk/page-celebrity-categories/jack-nicholson/", _knownForMovie = "The Shining", _oscarWinner = false });
                actorsList.Add(new Actors() { _firstName = "Leonardo", _lastName = "DiCaprio", _age = 43, _role = "", _contactinfo = "", _knownForMovie = "Inception", _oscarWinner = true });
                actorsList.Add(new Actors() { _firstName = "Tom", _lastName = "Hanks", _birthPlace="California", _age = 20, _role = "", _contactinfo = "", _oscarWinner = false });
                actorsList.Add(new Actors() { _firstName = " ", _lastName = "", _age = 50, _role = "", _contactinfo = "", _knownForMovie = "", _oscarWinner = true });
            }
           

            foreach (var actors in actorsList)
            {
                
                Console.WriteLine("" +  actors.Fullname);
                Console.WriteLine("1. First name: " + actors._firstName);
                Console.WriteLine("2. Last name: " + actors._lastName);
                Console.WriteLine("3. Birthday " + actors.birthday);
                Console.WriteLine("4. Born in: " + actors._birthPlace);
                Console.WriteLine("5. Roles: " + actors._role);
                Console.WriteLine("6. Age: " + actors._age);
                Console.WriteLine("7. Contact infos: " + actors._contactinfo);
                Console.WriteLine("8. The most rated film: " + actors._knownForMovie);           
                if (actors._oscarWinner == true)                   
                {
                    Console.WriteLine("When " + actors.Fullname + " won the Oscar?");
                    var oscarGlobe = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("9. Winner of the Oscar Globe in: " + oscarGlobe);
                }
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}     
