using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionService;

namespace Action.API.Controllers
{
    public class Default1Controller : Controller
    {
        protected readonly IService _service;

        public Default1Controller(IService service)
        {
            _service = service;
        }

        //
        // GET: /Default1/
        public ActionResult Index()
        {
            _service.GetCategories();
            return View();
        }
	}
}