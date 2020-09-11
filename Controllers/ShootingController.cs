using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShooterServiceDemo.Contexts;
using ShooterServiceDemo.Models.ContextModels;
using ShooterServiceDemo.Models.RequestModels;

namespace ShooterServiceDemo.Controllers
{
    public class ShootingController : ControllerBase
    {
        private readonly ILogger<ShootingController> _logger;
        private RepositoryContext _context;

        public ShootingController(ILogger<ShootingController> logger, RepositoryContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        [Route("/Shooting/Save")]
        public IActionResult Save(NewShooting record)
        {
            _context.ShootingRecords.Add(new ShootingRecord
            {
                DeadID = record.DeadID,
                ShooterID = record.ShooterID,
                HitZoneID = record.HitZoneID,
                ShootingTime = DateTime.Now
            });
            _context.SaveChanges();
            return Redirect("/");
        }
    }
}
