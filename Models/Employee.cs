using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class Employee:BaseModel
    {
        /// <summary>
        /// 员工姓名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        [Required]
        public Department Depart { get; set; }

        /// <summary>
        /// 位置:六楼/二楼
        /// </summary>
        [Required]
        public Position Position { get; set; }
    }
}
