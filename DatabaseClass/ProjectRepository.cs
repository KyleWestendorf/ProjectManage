using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManageDAL
{
    public static class ProjectRepository
    {

        public static void Add_Project(string reseller, string customer, string product, int salesOrder, string description)
        {
            using (var context = new Context())
            {

                context.Projects.Add(new Project()
                {

                    Reseller = reseller,
                    Customer = customer,
                    Product = product,
                    SalesOrder = salesOrder,
                    Description = description,
                    Complete = false
                });
                
                context.SaveChanges();

            }     
        }

        public static Project Get_Project_By_Sales_Order_Number(int id)
        {
            using (var context = new Context())
            {
                var returnedProject = context.Projects.SingleOrDefault(project => (project.SalesOrder == id));

                return returnedProject;
            }
        }

        public static void UpdateProject(Project project)
        {
            using (var context = new Context())
            {

                context.Projects.Attach(project);
                context.Entry(project).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }

        
    }
}
