using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract partial class BaseModel
    {
        [Key]
        public int Id { get; set; }

        public int? Order { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
    }
}
