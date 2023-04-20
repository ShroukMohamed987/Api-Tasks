using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.BL.Dtos
{
    public class TicketDto
    {
        public  int Id { get; set; }
        public  string Title { get; set; } = string.Empty;
        public  string Description { get; set; } = string.Empty;

        public  int DevelopersCount { get; set; }
        public List<DeveloperDto> Developers { get; set; } = new();
    }
}
