using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.BL.Dtos
{
    public class DeveloperDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<TicketDto> TicketList { get; set; } = new();
    }
}
