using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class OrderDetail
    {
        /// <summary>
        /// 所属订单
        /// </summary>
        [Required]
        public Order OrderHeader { get; set; }

        /// <summary>
        /// 所属员工
        /// </summary>
        [Required]
        public Employee Employee { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal TotalAmt { get; set; }

        /// <summary>
        /// 补贴
        /// </summary>
        public decimal Subsidy { get; set; }

        public IEnumerable<OrderSubDetail> SubDetails { get; set; }
    }
}
