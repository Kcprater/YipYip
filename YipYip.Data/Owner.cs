using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Data
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        [Required]
        public string OwnerName { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public int Rating { get; set; }
        
    }
}
