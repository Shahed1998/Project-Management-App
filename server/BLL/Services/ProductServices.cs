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
    public class ProductServices
    {
        public static ProductDTO Add(ProductDTO dto)
        {
            var config = new MapperConfiguration(
               cfg => { cfg.CreateMap<Project, ProductDTO>(); cfg.CreateMap<ProductDTO, Project>(); }
           );
            var mapper = new Mapper(config);
            var proj = mapper.Map<Project>(dto);
            DataAccessFactory.AddProject().Add(proj);
            return mapper.Map<ProductDTO>(proj);
        }
    }
}
