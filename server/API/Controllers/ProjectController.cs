using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ProjectController : ApiController
    {
        [Route("api/project/add")]
        [HttpPost]
        public HttpResponseMessage Add(ProductDTO dto)
        {
            dto.Issue_Date = DateTime.Now;
            dto.Status = 1;

            var resp = ProductServices.Add(dto);
            return Request.CreateResponse(HttpStatusCode.OK, resp);
        }
    }
}
