using ProjectManageDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projects.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Project
        public ActionResult Index(Project project)
        {
            return View("ProjectPage", project);
        }

        public ActionResult ProjectPage(int salesOrderNumber)
        {
            var returnedProject = ProjectManageDAL.ProjectRepository.Get_Project_By_Sales_Order_Number(salesOrderNumber);
            return View();
        }

        public ActionResult Edit(Project project)
        {
            return View(project);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditPost(Project project)
        {
            ProjectRepository.UpdateProject(project);
            return RedirectToAction("Index", project);
        }
    }
}