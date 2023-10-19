using ComeBackMVC.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComeBackMVC.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }
        public int CategoryID { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        [Required]
        public bool HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public bool? ViewCount { get; set; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { get; set; }
    }
}
