using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Poll_MVC.Domain.Commands;
using Poll_MVC.Domain.Handlers;
using Poll_MVC.Infra.Contexts;
using System.Threading.Tasks;

namespace Poll_MVC.Controllers
{
    public class PollController : Controller
    {
        private readonly AppDbContext _context;

        public PollController(AppDbContext context) { _context = context; }

        public IActionResult Index()
        {
            var polls = _context
                            .Polls
                            .Include(x => x.Views)
                            .AsNoTracking();

            return View(polls);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(
            [FromServices] PollHandler handler,
            [Bind("Poll_description,Option1,Option2,Option3")] CreatePollCommand command
        )
        {
            var result = handler.Handle(command);
            return RedirectToAction(nameof(Index));
        }
    }
}
