using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, bool> GetAllUsers()
        {
            return new UserRepo();
        }

        public static IRepo<User, bool> AddUsers()
        {
            return new UserRepo();
        }

        public static IRepo<Project, bool> AddProject()
        {
            return new ProductRepo();
        }
    }
}
