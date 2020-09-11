using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShooterServiceDemo.Models.RequestModels
{
    public class NewShooting
    {
        public int ShooterID { get; set; }
        public int DeadID { get; set; }
        public int HitZoneID { get; set; }
    }
}
