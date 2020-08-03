using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> 73524be85bb9dd1ceb4d82f39f096219b9d47e35
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Data
{
<<<<<<< HEAD
<<<<<<<< HEAD:YipYip.Data/Profile.cs
    public class Profile
========
    public class Owner 
>>>>>>>> 73524be85bb9dd1ceb4d82f39f096219b9d47e35:YipYip.Data/Owner.cs
=======
    public class Profile
>>>>>>> 73524be85bb9dd1ceb4d82f39f096219b9d47e35
    {
        [Key]
        public int ProfileId { get; set; }
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string ProfileName { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
<<<<<<< HEAD
<<<<<<<< HEAD:YipYip.Data/Profile.cs
        [Required]
        public int Rating { get; set; }

========
        public int? Rating { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [ForeignKey(nameof(ProfileId))]
        [Required]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual ICollection<Property> OwnerProperties { get; set; } = new List<Property>();
>>>>>>>> 73524be85bb9dd1ceb4d82f39f096219b9d47e35:YipYip.Data/Owner.cs
    }
}


=======
        [Required]
        public int Rating { get; set; }
    }
}
>>>>>>> 73524be85bb9dd1ceb4d82f39f096219b9d47e35
