using Lab2.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab2.DAL.Reposatory.Tickets
{
    public interface ITicket
    {
        IEnumerable<Ticket> GetTickets();
        Ticket? GetBYiD(int id);
        void add(Ticket ticket);
        void remove(int id);
        void update(Ticket ticket);
        void saveChanges();
        Department? GetDeveloperWithTicket(int id);
    }
    //public interface IDeveloper
    //{
    //    public Develpoer? GetDeveloperWithTicket(int id);
    //}
}
