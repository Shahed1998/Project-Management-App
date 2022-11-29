using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : IRepo<User, bool>
    {
        Project_ManagementEntities db;
        internal UserRepo()
        {
            db = new Project_ManagementEntities();
        }

        public bool Add(User obj)
        {
            db.Users.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            db.Users.Remove(db.Users.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User obj)
        {
            var ext = db.Users.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
