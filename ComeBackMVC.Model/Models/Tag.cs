using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComeBackMVC.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(256)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        public string Type { get; set; }

    }
}
