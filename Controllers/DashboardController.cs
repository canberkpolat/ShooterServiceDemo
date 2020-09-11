using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShooterServiceDemo.Contexts;
using ShooterServiceDemo.Models.ContextModels;

namespace ShooterServiceDemo.Controllers
{
    [Route("/")]
    public class DashboardController : Controller
    {
        private readonly RepositoryContext _context;

        public DashboardController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index([FromQuery] int page = 1, int pageSize=10)
        {
            int skip = (page - 1) * pageSize;
            dynamic d = new System.Dynamic.ExpandoObject();
            int totalPages = (int)Math.Ceiling(_context.ShootingRecords.Count()/(decimal)pageSize);
            d.Records = _context.ShootingRecords
                .OrderByDescending(p => p.ShootingTime)
                .Skip(skip)
                .Take(pageSize)
                .ToList();
            d.PageSize = pageSize;
            d.CurrentPage = page;
            d.TotalPages = totalPages;
            return View(d);
        }
    }
}
