using System;
namespace TicketContainer
{
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

		void printTicket()
		{
			Console.WriteLine("╔══════════════════════════════════════════════╗");
			Console.WriteLine("║		ID:{0}║", this.id);
			Console.WriteLine("║		Source:{0}║", this.scr);
			Console.WriteLine("║		Destination:{0}║", this.dest);
			Console.WriteLine("╚══════════════════════════════════════════════╝");
		}
	}
}

