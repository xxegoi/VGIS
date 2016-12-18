using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using MVC_VGIS.Models.VGIS;
using Models;
using System.Reflection;

namespace MVC_VGIS.Controllers.VGIS
{
    public class SupplierController : Controller
    {
        SupplierBLL bll = new SupplierBLL();

        // GET: Supplier
        public ActionResult Index()
        {
            List<Supplier> lst = bll.Query(m => !m.IsDeleted).ToList();

            List<SupplierViewModel> models = new List<SupplierViewModel>();

            lst.ForEach(m =>
            {
                models.Add(new SupplierViewModel(m));
            });

            return View(models);
        }

        public ActionResult Create()
        {
            SupplierViewModel model = new SupplierViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SupplierViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bll.Add(model.ToEntry());
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            SupplierViewModel model =new SupplierViewModel( bll.Query(m => m.Id == id).FirstOrDefault());

            return View(model);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            bll.DeleteById(id);

            return RedirectToAction("Index");
        }
    }
}