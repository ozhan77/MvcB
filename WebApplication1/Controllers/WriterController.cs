using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class WriterController : Controller
    {
        // GET: Writer
        WriterManager wm=new WriterManager(new EFWriterDal());
        public ActionResult Index()
        {
            var writerValues = wm.GetList();
            return View(writerValues);
        }
    }
}