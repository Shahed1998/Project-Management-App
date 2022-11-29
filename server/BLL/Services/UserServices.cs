using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserServices
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.GetAllUsers().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);
            var users = mapper.Map<List<UserDTO>>(data);
            return users;
        }

        public static UserDTO Get(int id)
        {
            var data = DataAccessFactory.GetAllUsers().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);
            var user = mapper.Map<UserDTO>(data);
            return user;
        }

        public static UserDTO Add(UserDTO dto)
        {
            var config = new MapperConfiguration(
                cfg => { cfg.CreateMap<User, UserDTO>(); cfg.CreateMap<UserDTO, User>(); }
            );
            var mapper = new Mapper(config);
            var user = mapper.Map<User>(dto);
            DataAccessFactory.AddUsers().Add(user);
            return mapper.Map<UserDTO>(user);
        }
    }
}
