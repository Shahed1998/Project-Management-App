using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProductRepo : IRepo<Project, bool>
    {
        Project_ManagementEntities db;

        internal ProductRepo()
        {
            db = new Project_ManagementEntities();
        }

        public bool Add(Project @class)
        {
            db.Projects.Add(@class);
            db.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> Get()
        {
            throw new NotImplementedException();
        }

        public Project Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Project @class)
        {
            throw new NotImplementedException();
        }
    }
}
