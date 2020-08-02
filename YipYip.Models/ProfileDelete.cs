using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Models
{
    public class ProfileDelete
    {
        [Required]
        [Display(Name = "Profile ID")]
        public int ProfileId { get; set; }
        
    }
}
