<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> 73524be85bb9dd1ceb4d82f39f096219b9d47e35
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Models
{
    public class ProfileEdit
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

        [Display(Name = "Rating")]
        public int Rating { get; set; }
    }
}
