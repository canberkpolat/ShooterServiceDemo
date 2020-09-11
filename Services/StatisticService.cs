using Microsoft.EntityFrameworkCore;
using ShooterServiceDemo.Contexts;
using ShooterServiceDemo.Models;
using ShooterServiceDemo.Models.ContextModels;
using ShooterServiceDemo.Models.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ShooterServiceDemo.Services
{
    [ServiceContract]
    public class StatisticService
    {
        private RepositoryContext _context;
        public StatisticService (RepositoryContext context)
        {
            _context = context;
        }
        [OperationContract]
        public List<HitDetails> CheckHitList()
        {
            IEnumerable<ShootingRecord> records = _context.ShootingRecords.OrderByDescending(p => p.ShootingTime).Take(10).ToArray();
            List<HitDetails> response = new List<HitDetails>();
            foreach(ShootingRecord record in records)
            {
                response.Add(new HitDetails
                {
                    HitID = record.ID.ToString(),
                    Shooter = record.ShooterID.ToString(),
                    Dead = record.DeadID.ToString(),
                    HitZone = new HitZone(record.HitZoneID).Value
                });
            }
            return response;
        }

        [OperationContract]
        public GamerDetails CheckUser(int UserID)
        {
            User u = _context.Users.Where(p => p.ID == UserID).Include(x => x.Shootings).FirstOrDefault();
            double score = 0;
            foreach(ShootingRecord record in u.Shootings)
            {
                score += 10 / new HitZone(record.HitZoneID).ID;
            }
            return new GamerDetails
            {
                GamerID = u.ID.ToString(),
                UserName = u.UserName,
                NickName = u.NickName,
                Score = score.ToString()
            };
        }
    }
}
