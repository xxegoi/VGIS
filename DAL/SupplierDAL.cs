using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace DAL
{
    public partial class SupplierDAL
    {
        SupplierContext db = new SupplierContext();

        #region 增\删\改\查

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(Supplier model)
        {

            db.Suppliers.Add(model);

            return db.SaveChanges();
        }

        /// <summary>
        /// 根据传入实体删除数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Delete(Supplier model)
        {
            DbEntityEntry<Supplier> entry = db.Entry<Supplier>(model);
            entry.State = EntityState.Unchanged;
            entry.Entity.IsDeleted = true;

            entry.Property("IsDeleted").IsModified = true;

            return db.SaveChanges();
        }

        /// <summary>
        /// 根据Id删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteById(int id)
        {
            Supplier model = new Supplier() { Id = id };

            DbEntityEntry<Supplier> entry = db.Entry<Supplier>(model);
            entry.State = EntityState.Unchanged;
            entry.Entity.IsDeleted = true;

            entry.Property("IsDeleted").IsModified = true;

            return db.SaveChanges();
        }

        /// <summary>
        /// 修改实体属性值
        /// </summary>
        /// <param name="model">修改后的实体</param>
        /// <param name="property">修改的属性</param>
        /// <returns></returns>
        public int Update(Supplier model)
        {
            DbEntityEntry entry = db.Entry<Supplier>(model);

            entry.State = EntityState.Unchanged;

            Type t = typeof(Supplier);

            foreach (PropertyInfo pi in t.GetProperties())
            {
                var value = pi.GetValue(model);

                if (entry.Property(pi.Name).CurrentValue != value)
                {
                    entry.Property(pi.Name).CurrentValue = value;
                    entry.Property(pi.Name).IsModified = true;
                }
            }

            return db.SaveChanges();
        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="condition">查询条件,一个传入值是Supplier,返回值是Bool的方法</param>
        /// <returns></returns>
        public IEnumerable<Supplier> Query(Expression<Func<Supplier, bool>> condition)
        {
            if (condition == null)
            {
                return db.Suppliers.AsEnumerable();
            }

            return db.Suppliers.Where(condition);
        }
        
        #endregion



    }

    /// <summary>
    /// Supplier的数据上下文类
    /// </summary>
    public partial class SupplierContext : DbContext
    {
        public SupplierContext() : base("VGIS") { }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
    }
}
