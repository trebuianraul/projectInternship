using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace FilmLibrary
{
    
    class MainClass {
        ~MainClass()
        {
            Console.WriteLine("finalizer active");
        }
        static FileStream fs;
        static StreamWriter sw;

        public delegate void Filming(string s);


        public static void CallTheDelegate(Filming z)
        {
            string s = "A new film will be encoded shortly after";
            byte[] utf8Bytes = System.Text.Encoding.UTF8.GetBytes(s);
            Console.WriteLine(utf8Bytes.Length);
            z(s);
            z("Dimension allocated for 8 Bytes: ");
            z(utf8Bytes.Length.ToString());

            byte[] utf16Bytes = System.Text.Encoding.Unicode.GetBytes(s);
            Console.WriteLine(utf16Bytes.Length);
            z(s);
            z("Dimension allocated for 16 Bytes: ");
            z(utf16Bytes.Length.ToString());

            string newString = System.Text.Encoding.ASCII.GetString(utf8Bytes);
            z(newString);
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream(@"D:\FilmLibrary\FilmLibrary\FilmLibrary\File.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
            fs.Dispose();
            Console.ReadLine();
        }


        static void Main(string[] args)
        {

            Movie movie = new Movie();
            Actors a = new Actors();
            a.ActorsList();
            movie.SearchingTitle("A new world");

            Filming f = new Filming(WriteToFile);
            // CallTheDelegate(f);
            Console.ReadKey();
            movie.FormattingTitle();
            movie.CompareTitle();
            movie.MovieTime();
            movie.Price("A new world", "United Kingdom");
            movie.Price("Beauty and the beast", "Dennmark");


            Film film = new Movie();
            film.ShowCast("Andy", "director");
            film.ShowCast("Derek", "cameraman", 23);
            film.ShowCast("Joshua", "scripter", 32, true);
            film.Review(title: "Titanic", rating: 10);
            film.ListWithMovies();
            film.FullName();
            film.ShowTitle("Titanic");
            film.DescriptionMovie("Titanic", "is a new production");

            Console.WriteLine("Press 1 for tv series");
            Console.WriteLine("Press 2 for movie");
            string input = Console.ReadLine();
            var movie1 = FilmProductionFactory.CreateMovie();
            Console.WriteLine("From Film class: " + movie1.getTitle());
            Console.Read();

            Console.ReadLine();

            Proxy server = new Proxy();
            server.TakeOrder("pizza", "Spiderman");
            server.DeliveryOrder();
            server.Payment("no money");

            Console.ReadLine();
            var something = new NewTicketProxy();
            something.TakeOrder("tomato", "Spider-man");
            something.DeliveryOrder();
            something.Payment("more money");
            Console.ReadLine();

            //Decorator
            Popcorn saltPopcorn = new Popcorn("Sea salt", "baked cheese");
            saltPopcorn.Display();
            Console.ReadLine();

            Nachos blackNachos = new Nachos("black topping", "hot sauce");
            blackNachos.Display();
            Console.ReadLine();

            Decorator blackNachosDecorator = new Decorator(blackNachos);
            Drink colaDrink = new Drink("juice", "Coca-Cola", 500);
            colaDrink.Display();
            Console.ReadLine();


            //Dependecy Injection with Kernel container
            Ninject.IKernel kernel = new StandardKernel();
            kernel.Bind<ISeller>().To<Seller>();
            var instance = kernel.Get<DependencyInjection>();
            instance.Call();
            Console.ReadLine();

            //Strategy
            var turkeySandwich = new TurkeySandwich();
            turkeySandwich.CreateIngredients();

            Console.ReadLine();

            CookingMethod cookMethod = new CookingMethod();
            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            cookMethod.SetFood(food);
            Console.WriteLine("What cooking strategy would you like to use (1-3)?");

            int input1 = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input1)
            {
                case 1:
                    cookMethod.SetCookStrategy(new Grilling());
                    cookMethod.Cook();
                    break;
                case 2:
                    cookMethod.SetCookStrategy(new OvenBaking());
                    cookMethod.Cook();
                    break;
                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
            Console.ReadLine();

            Movie m = new Movie();
            m.ListMovies();


            
        }
    }
}