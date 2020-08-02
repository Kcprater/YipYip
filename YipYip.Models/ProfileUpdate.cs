using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Models
{
    public class ProfileUpdate
    {
        [Required]
        public int ProfileId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string ProfileName { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public int Phone { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public int Rating { get; set; }
    }
}
