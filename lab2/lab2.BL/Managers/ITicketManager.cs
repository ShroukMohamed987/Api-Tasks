using lab2.BL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.BL.Managers
{
    public interface ITicketManager
    {
        IEnumerable<TicketDto> GetAll();
        TicketDto GetById(int id);
        void update (TicketDto ticket);
        void delete(int id);
        void AddTicket(TicketDto ticket);
        DeveloperDto? GetDetails(int id);
    }
}
