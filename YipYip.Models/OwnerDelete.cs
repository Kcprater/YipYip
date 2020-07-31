using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Models
{
    public class OwnerDelete
    {
        [Required]
        [Display(Name = "Owner ID")]
        public int OwnerId { get; set; }
        
    }
}
