using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Models
{
    public partial class Supplier:BaseModel
    {
        /// <summary>
        /// 商家名称,不能为空
        /// </summary>
        [Required]
        [MaxLength(50)]
        [DisplayName("商家名称")]
        public string Name { get; set; }

        /// <summary>
        /// 商家电话,不能为空
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        /// <summary>
        /// 商家地址
        /// </summary>
        [MaxLength(200)]
        public string Addr { get; set; }

        /// <summary>
        /// 加蛋价钱
        /// </summary>
        [Required]
        public decimal EggPrice { get; set; }

        /// <summary>
        /// 菜式列表
        /// </summary>
        public IEnumerable<MenuItem> MenuItems { get; set; }
    }
}
