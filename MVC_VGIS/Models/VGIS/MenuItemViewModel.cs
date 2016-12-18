using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_VGIS.Models.VGIS
{
    public partial class MenuItemViewModel:BaseViewModel
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
        public SupplierViewModel Supplier { get; set; }

        public MenuItemViewModel() { }

        public MenuItemViewModel(MenuItem entry)
        {
            this.Id = entry.Id;
            this.Name = entry.Name;
            this.Price = entry.Price;
            this.Desc = entry.Desc;
            this.Supplier = new SupplierViewModel(entry.Supplier);
        }
    }
}