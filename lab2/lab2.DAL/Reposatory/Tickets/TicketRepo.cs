using Lab2.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.DAL.Reposatory.Tickets
{
    public class TicketRepo : ITicket
    {
        public LabContext Context { get; }
        public TicketRepo(LabContext _context)
        {
            Context = _context;
        }

        

        public void add(Ticket ticket)
        {
            Context.Add(ticket);
        }

        public Ticket? GetBYiD(int id)
        {
            return Context.Set<Ticket>().Find(id);
        }

        public IEnumerable<Ticket> GetTickets()
        {
            return Context.Set<Ticket>();
        }

        

        public void saveChanges()
        {
            Context.SaveChanges();
        }

        public void update(Ticket ticket)
        {
            Context.Update(ticket);
        }

        public void remove(int id)
        {
            var ticket = Context.Set<Ticket>().Find(id);
            if (ticket != null)
            {
                Context.Remove(ticket);
            }
        }

        public Department? GetDeveloperWithTicket(int id)
        {
            return Context
               .Set<Department>()
               .Include(t => t.Tickets)
               .ThenInclude(d => d.develpoers)
               .FirstOrDefault(d => d.Id == id);
        }
    }
}
