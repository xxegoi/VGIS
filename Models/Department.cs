using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class Department:BaseModel
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
