using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BhavikAPI.Controllers
{
    public class BhavikAPIController : ApiController
    {
        private Bhavik_APIEntities context = new Bhavik_APIEntities();
        [HttpGet]
        public IEnumerable<employee> Getdata()
        {
            IEnumerable<employee> countries = context.employees;
            if (countries == null)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, "No record(s) found."));
            }
            else
            {     //List<employee> simple = 
                return countries;
            }
        }
    }
}
