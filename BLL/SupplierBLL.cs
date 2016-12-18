using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Linq.Expressions;

namespace BLL
{
    public class SupplierBLL
    {
        #region 增\删\改\查

        SupplierDAL db = new SupplierDAL();

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(Supplier model)
        {

            return db.Add(model);

        }

        /// <summary>
        /// 根据传入实体删除数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Delete(Supplier model)
        {
            return db.Delete(model);
        }

        /// <summary>
        /// 根据Id删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteById(int id)
        {
            return db.DeleteById(id);
        }

        /// <summary>
        /// 修改实体属性值
        /// </summary>
        /// <param name="model">修改后的实体</param>
        /// <param name="property">修改的属性</param>
        /// <returns></returns>
        public int Update(Supplier model)
        {
            return db.Update(model);
        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="condition">查询条件,一个传入值是Supplier,返回值是Bool的方法</param>
        /// <returns></returns>
        public IEnumerable<Supplier> Query(Expression<Func<Supplier, bool>> condition)
        {
            return db.Query(condition);
        }

        #endregion
    }
}
