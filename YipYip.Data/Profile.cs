using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Data
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        [Required]
        public string ProfileName { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public int Rating { get; set; }
        public Guid OwnerId { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
    }
}
