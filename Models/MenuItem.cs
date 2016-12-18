using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class MenuItem:BaseModel
    {
        /// <summary>
        /// 菜式名称
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [MaxLength(50)]
        public string Desc { get; set; }


        /// <summary>
        /// 所属供应商
        /// </summary>
        [Required]
        public Supplier Supplier { get; set; }
    }
}
