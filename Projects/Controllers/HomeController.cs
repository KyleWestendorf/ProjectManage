using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseClass;
namespace Projects.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Project project)
        {

            DatabaseClass.ProjectRepository.AddProject(project.Reseller, project.Customer, project.Product);

            return View("ProjectPage", project);
        }
    }
}