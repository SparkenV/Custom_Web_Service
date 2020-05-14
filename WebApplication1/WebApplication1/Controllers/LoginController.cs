using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class LoginController : ApiController
    {
        private readonly IICUTechservice techservice;

        public LoginController()
        {
            techservice = new IICUTechservice();
        }
        
        [HttpPost]
        public string Login([FromBody]JObject data)
        {
            string username = data.GetValue("username").ToString();
            string password = data.GetValue("password").ToString();
            string ips = data.GetValue("ips").ToString();

            var result = techservice.Login(username, password, ips);
            

            return (string)result;
        }
    }
}