using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Models;
using System.ComponentModel;

namespace MVC_VGIS.Models.VGIS
{
    public partial class SupplierViewModel : BaseViewModel
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
        [DataType(DataType.PhoneNumber)]
        [DisplayName("电话")]
        public string Phone { get; set; }

        /// <summary>
        /// 商家地址
        /// </summary>
        [MaxLength(200)]
        [DisplayName("地址")]
        public string Addr { get; set; }

        /// <summary>
        /// 加蛋价钱
        /// </summary>
        [Required]
        [DisplayName("加蛋价钱")]
        [DataType(DataType.Currency)]
        public decimal EggPrice { get; set; }

        public SupplierViewModel() { }


        //由实体类转换视图类
        public SupplierViewModel(Supplier entry)
        {
            if(entry!=null)
            {

                this.Id = entry.Id;
                this.Name = entry.Name;
                this.Addr = entry.Addr;
                this.Phone = entry.Phone;
                this.EggPrice = entry.EggPrice;
                this.Order = entry.Order;
                this.IsDeleted = entry.IsDeleted;
            }

        }

        //转换为实体类
        public Supplier ToEntry()
        {
            return new Supplier()
            {
                Id = this.Id,
                Name = this.Name,
                Addr = this.Addr,
                Phone = this.Phone,
                EggPrice = this.EggPrice,
                Order = this.Order,
                IsDeleted = this.IsDeleted
            };
        }
    }
}