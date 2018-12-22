using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseClass
{
    public static class ProjectRepository
    {

        public static void AddProject(string reseller, string customer, string product)
        {
            using (var context = new Context())
            {

                context.Projects.Add(new Project()
                {

                    Reseller = reseller,
                    Customer = customer,
                    Product = product
                });

                context.SaveChanges();

            }


              
        }
    }
}
