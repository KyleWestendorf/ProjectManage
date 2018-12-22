using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManageDAL;
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

            ProjectManageDAL.ProjectRepository.Add_Project(project.Reseller, project.Customer, project.Product, project.SalesOrder, project.Description);

            return View("../Projects/ProjectPage", project);
        }

        [HttpPost]
        public ActionResult FindProject(int salesOrder)
        {
            Console.WriteLine(salesOrder);
            var returnedProject = ProjectManageDAL.ProjectRepository.Get_Project_By_Sales_Order_Number(salesOrder);
            Console.WriteLine(returnedProject.Description);
            

            return RedirectToAction("Index", "Projects", returnedProject);
        }
    }
}