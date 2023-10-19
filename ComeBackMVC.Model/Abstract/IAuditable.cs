using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComeBackMVC.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
        string MetaKeyWord { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
    }
}
