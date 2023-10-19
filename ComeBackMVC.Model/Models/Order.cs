using ComeBackMVC.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ComeBackMVC.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }

        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerMobile { get; set; }
        public string CustomerMessage { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        [ForeignKey("ID")]
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
