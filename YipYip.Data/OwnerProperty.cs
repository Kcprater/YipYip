using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Data
{
    public class OwnerProperty
    {
        [Key]
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int PopertyId { get; set; }
    }
}
