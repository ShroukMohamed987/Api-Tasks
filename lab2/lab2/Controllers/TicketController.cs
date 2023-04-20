using lab2.BL.Dtos;
using lab2.BL.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        //inject manager instead of context
        private readonly ITicketManager ticketManager;
        public TicketController(ITicketManager _ticketManager)
        {
            ticketManager = _ticketManager;

        }
        [HttpGet]
        public ActionResult<IEnumerable<TicketDto>> GetAll()
        {
            return ticketManager.GetAll().ToList();

        }
        [HttpGet]
        [Route( "{id}")]
        public ActionResult<TicketDto> GetById(int id)
        {
            return ticketManager.GetById(id);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<DeveloperDto> GetDetails(int id)
        {
            DeveloperDto? ticket= ticketManager.GetDetails(id);
            return ticket;
        }
    }
}
