using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_EF.Models;

namespace MVC_EF.Controllers
{
    public class FootballSchedulesController : Controller
    {
        private readonly DB_128040_practiceContext _context;

        public FootballSchedulesController(DB_128040_practiceContext context)
        {
            _context = context;
        }

        // GET: FootballSchedules
        public async Task<IActionResult> Index()
        {
              return _context.FootballSchedules != null ? 
                          View(await _context.FootballSchedules.ToListAsync()) :
                          Problem("Entity set 'DB_128040_practiceContext.FootballSchedules'  is null.");
        }

        // GET: FootballSchedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FootballSchedules == null)
            {
                return NotFound();
            }

            var footballSchedule = await _context.FootballSchedules
                .FirstOrDefaultAsync(m => m.Id == id);
            if (footballSchedule == null)
            {
                return NotFound();
            }

            return View(footballSchedule);
        }


        private bool FootballScheduleExists(int id)
        {
          return (_context.FootballSchedules?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
