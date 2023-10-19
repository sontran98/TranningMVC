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
    [Table("OrderDetails")]
    public class OrderDetail : Auditable
    {
        [Key]
        public int OrderID { get; set; }
        [Key]
        public int ProductID { get; set; }

        public int Quantity { get; set; }
        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
