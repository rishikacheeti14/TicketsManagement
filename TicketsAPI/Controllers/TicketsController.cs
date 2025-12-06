using Microsoft.AspNetCore.Mvc;
using TicketsAPI.Models;

namespace TicketsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> GetTickets()
        {
            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    ShortDescription = "Login issue",
                    Description = "User cannot login with valid credentials.",
                    CreatedDate = new DateTime(2025, 1, 10),
                    Severity = "High",
                    TargetDate = new DateTime(2025, 1, 15),
                    Status = "Open"
                },
                new Ticket
                {
                    Id = 2,
                    ShortDescription = "UI bug on dashboard",
                    Description = "Graphs not loading for some users.",
                    CreatedDate = new DateTime(2025, 1, 12),
                    Severity = "Medium",
                    TargetDate = new DateTime(2025, 1, 20),
                    Status = "In Progress"
                },
                new Ticket
                {
                    Id = 3,
                    ShortDescription = "Password reset email",
                    Description = "Password reset email not sent.",
                    CreatedDate = new DateTime(2025, 1, 13),
                    Severity = "Low",
                    TargetDate = new DateTime(2025, 1, 25),
                    Status = "Closed"
                }
            };

            return Ok(tickets);
        }
    }
}
