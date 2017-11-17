using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoJqueryAjax.Models;

namespace TodoJqueryAjax.Controllers
{
    public class AppController : Controller
    {
        private TodoJqueryAjaxContext db = new TodoJqueryAjaxContext();

        public ActionResult Index()
        {            
            return View();
        }

        public JsonResult List()
        {
            var tasks = db.Tasks.ToList();
            return Json(tasks, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]       
        public JsonResult Create(Task task)
        {           
            db.Tasks.Add(task);
            db.SaveChanges();
            return Json(new { task.Id });
        }


    }
}