using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComeBackMVC.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime? VisitedDate { get; set; }
        public string IPAdress { get; set; }
    }
}
