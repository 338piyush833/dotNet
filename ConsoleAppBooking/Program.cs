using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBooking
{
    class Program
    {
        static List<Ticket> tickets=new List<Ticket>();

        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************\n       Welcome to Ticket Booking System      \n******************************************************");
            while (true)
            {
				Console.WriteLine("Select an Option:");
                Console.WriteLine("[1] View Tickets");
                Console.WriteLine("[2] Book a Ticket");
                Console.WriteLine("[3] Delete a Ticket");
                Console.WriteLine("[4] Update a Ticket");
                Console.WriteLine("»»» Press q/Q to Exit «««");
                String input = Console.ReadLine();
                if(input == "q" || input == "Q")
                    { 
                        break;
                    }
                switch ( int.Parse(input) )
                {
                    case 1 : 
                        ViewTicket();
                        break;
                    case 2 :
                        AddTicket();
                        break;
                    case 3 :
                        DeleteTicket();
                        break;
                    case 4 :
                        UpdateTicket();
                        break;
                }
            }
            Console.ReadLine();
        }

        public static void ViewTicket(){
            int i=0;
            for (i = 0; i < tickets.Count;i++)
            {
                tickets[i].PrintTicket();
            }
            if (tickets.Count == 0)
            {
                Console.WriteLine("No Data Found");
            }
        }

        public static void AddTicket(){
            Console.WriteLine("Enter ticket id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter source:");
            String source = Console.ReadLine();
            Console.WriteLine("Enter destination:");
            String destination = Console.ReadLine();
            tickets.Add(new Ticket(id,source,destination));
        }

        public static void DeleteTicket(){
            Console.WriteLine("Enter ticket ID to delete ticket:");
            String inputId = Console.ReadLine();
            int id = int.Parse(inputId);
            var deleteTicket = tickets.FindAll(r => r.GetId() == id);
            if (deleteTicket.Count == 0)
            {
                Console.WriteLine("No Ticket Found to Delete!");
            }else{
                tickets.RemoveAll(r => r.GetId() == id);
                Console.WriteLine("Successfully Deleted!");
            } 
        }

        public static void UpdateTicket(){
            Console.WriteLine("Enter ticket id to Update:");
            int id = int.Parse(Console.ReadLine());
            var updateTicket = tickets.FirstOrDefault(r => r.GetId() == id);
            if (updateTicket == null)
            {
                Console.WriteLine("No Ticket Found to Update!");
            }
            else 
            {
                Console.WriteLine("Enter source:");
                String source = Console.ReadLine();
                Console.WriteLine("Enter destination:");
                String destination = Console.ReadLine();
                updateTicket.EditTicket(source,destination);
                Console.WriteLine("Successfully Updated!");
            }
        }

        public class Ticket
	    {
		    int id;
		    String src;
		    String dest;

		    public Ticket(int id, String src, String dest)
		    {
			    this.id = id;
			    this.src = src;
			    this.dest = dest;
		    }

            public int GetId()
            {
                return this.id;
            }

            public void EditTicket(String src, String dest)
            {
                this.src = src;
			    this.dest = dest;
            }

		    public void PrintTicket()
		    {
			    Console.WriteLine("╔═══════════════╦══════════════════════════════╗");
			    Console.WriteLine("║   ID          ║    {0}", this.id);
			    Console.WriteLine("║   Source      ║    {0}", this.src);
			    Console.WriteLine("║   Destination ║    {0}", this.dest);
			    Console.WriteLine("╚═══════════════╩══════════════════════════════╝");
		    }
	    }
    }

}
