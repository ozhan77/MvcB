using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using ClassLibrary1.Concrete;
using DataAccessLayer.EntityFramework;
using FluentValidation.Results;
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
        [HttpGet]
        public ActionResult AddWriter(Writer writer)
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer writer)
        {
            WriterValidator validationRules = new WriterValidator();
            ValidationResult results = validationRules.Validate(writer);
            if (results.IsValid)
            {
                wm.WriterAdd(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}