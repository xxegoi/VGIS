using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_VGIS.Models.VGIS
{
    public abstract partial class BaseViewModel
    {
        [Key]
        public int Id { get; set; }

        public int? Order { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
    }
}