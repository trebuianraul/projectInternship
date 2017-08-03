using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    class Proxy
    {
        private string ticket;
        private string title;
        public int seatnumber;
        public int rownumber;
        public DateTime startingtime;
        public DateTime durationtime;
        public string movie;
        public string genre;

        public void TakeOrder(string Ticket, string Title)
        {    
            Console.WriteLine("Sell " + ticket + " for the " + title);
            Ticket = ticket;
            Title = title;
        }

        public string DeliveryOrder()
        {
            return ticket;
        }

        public void Payment(string payment)
        {
            Console.WriteLine("Payment for the ticket: " + payment + " done");
        }
    }

    public class NewTicketProxy : ITickets
    {
        private string ticket;
        private string title;

        public void TakeOrder(string ticket, string title)
        {
            Console.WriteLine("Take the order for movie: " + title + "");
        }

        public string DeliveryOrder()
        {
            return ticket;
        }

        public void Payment(string payment)
        {
            Console.WriteLine("The money were payed");
        }
    }

    interface ITickets
    {
        void TakeOrder(string order, string title);
        string DeliveryOrder();
        void Payment(string payment);
    }
}
