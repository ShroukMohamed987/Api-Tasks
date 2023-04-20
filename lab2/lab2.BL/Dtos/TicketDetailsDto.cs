using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.BL.Dtos
{
    public class TicketDetailsDto
    {
        public required int Id { get; set; }
        public string Name { get; set; }
        public List<TicketDto> ticketsDetails { get; set; } = new();
        
    }
}
