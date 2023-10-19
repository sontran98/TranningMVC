using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComeBackMVC.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        public string URl { get; set; }
        public int DisplayOrder { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
