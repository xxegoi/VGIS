using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class Order:BaseModel
    {
        /// <summary>
        /// 点餐日期
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [Required]
        [DataType(DataType.Currency)]
        public decimal TotalAmt { get; set; }

        /// <summary>
        /// 点餐总数量
        /// </summary>
        [Required]
        public int TotalQty { get; set; }

        /// <summary>
        /// 开始点餐时间
        /// </summary>
        [Required]
        [DataType(DataType.Time)]
        public DateTime Start { get; set; }

        /// <summary>
        /// 结束点餐时间
        /// </summary>
        [Required]
        [DataType(DataType.Time)]
        public DateTime End { get; set; }

        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
