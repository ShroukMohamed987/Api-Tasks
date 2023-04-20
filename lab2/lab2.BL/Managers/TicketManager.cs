using lab2.BL.Dtos;
using lab2.DAL.Reposatory.Tickets;
using Lab2.DAL.Models;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace lab2.BL.Managers
{
    public class TicketManager : ITicketManager
    {
        public ITicket TicketRepo { get; }
        public IMapper _mapper { get; }

        public TicketManager(ITicket _ticketRepo, IMapper mapper)
        {
            TicketRepo = _ticketRepo;
            _mapper = mapper;
        }

        

        public IEnumerable<TicketDto> GetAll()
        {
            IEnumerable<Ticket> ticketFromDb = TicketRepo.GetTickets();
            ///map ticket to dto
            return ticketFromDb.Select(ticket => new TicketDto
            {
                Id = ticket.Id,
                Description = ticket.Description,
                Title = ticket.Title
            });
        }

        public TicketDto GetById(int id)
        {
            Ticket ticketFromDB = TicketRepo.GetBYiD(id);
            TicketDto ticket = new TicketDto();
            ticket.Id = ticketFromDB.Id ; ;
            ticket.Title = ticketFromDB.Title;
            ticket.Description = ticketFromDB.Description;
            return ticket;


            
        }

        public void update(TicketDto ticket)
        {
            Ticket da = _mapper.Map<Ticket>(ticket);
            TicketRepo.update(da);
            TicketRepo.saveChanges();
        }

        public void delete(int id)
        {
            TicketRepo.remove(id);
            TicketRepo.saveChanges();

        }

        public void AddTicket(TicketDto ticket)
        {
            Ticket added = _mapper.Map<Ticket>(ticket);
            TicketRepo.add(added);
            TicketRepo.saveChanges();
        }

        public TicketDetailsDto? GetDetails(int id)
        {
            var ticketFromDb = TicketRepo.GetDeveloperWithTicket(id);
            if(ticketFromDb == null)
            {
                return null;
            }
            else
            {
                return new TicketDetailsDto
                {
                    Id = ticketFromDb.Id,
                    Name = ticketFromDb.Name,
                    ticketsDetails = ticketFromDb.Tickets.Select(t => new TicketDto
                    {
                        Description = t.Description,
                        Title = t.Title,
                        Id = t.Id,
                        DevelopersCount = t.develpoers.Count
                    }).ToList()
                };
            }
        }

        DeveloperDto? ITicketManager.GetDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
