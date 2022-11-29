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
    public class UserController : ApiController
    {
        [Route("api/users")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/user/add")]
        [HttpPost]
        public HttpResponseMessage Add(UserDTO dto)
        {

            if (!ModelState.IsValid) 
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Msg="Failed", ModelState });

            var resp = UserServices.Add(dto);
            if (resp != null) 
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg="Successful",data=resp });

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
