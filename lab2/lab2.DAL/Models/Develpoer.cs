﻿namespace Lab2.DAL.Models
{
    public class Develpoer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();

    }
}
