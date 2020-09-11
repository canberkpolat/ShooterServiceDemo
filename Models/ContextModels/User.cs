using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShooterServiceDemo.Models.ContextModels
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public ICollection<ShootingRecord> Shootings { get; set; }

    }
}
