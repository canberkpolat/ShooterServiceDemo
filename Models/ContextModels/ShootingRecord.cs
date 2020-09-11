using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShooterServiceDemo.Models.ContextModels
{
    public class ShootingRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public long ShooterID { get; set; }
        public long DeadID { get; set; }
        public int HitZoneID { get; set; }
        public DateTime ShootingTime { get; set; }
    }
}
