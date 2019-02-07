using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AutomaticApiGeneration.Controllers
{
    public class TestController : ApiController
    {
        // GET api/test
        public IEnumerable<string> Get()
        {
            return new string[] { "test", "test2" };
        }
        // GET api/test/1
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "test" };
        }
    }
}
