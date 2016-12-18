using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class OrderSubDetail:BaseModel
    {
        /// <summary>
        /// 所属点餐明细
        /// </summary>
        [Required]
        public OrderDetail OrderDetail { get; set; }

        /// <summary>
        /// 菜式
        /// </summary>
        [Required]
        public MenuItem MenuItem { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [Required]
        public int Qty { get; set; }

        /// <summary>
        /// 是否辣
        /// </summary>
        [Required]
        public bool Spicy { get; set; }

        /// <summary>
        /// 是否加蛋
        /// </summary>
        [Required]
        public bool IsEgg { get; set; }
    }
}
