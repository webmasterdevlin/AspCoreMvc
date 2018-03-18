using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationEmpty.Controllers
{
    // about

    [Route("company/[controller]/[action]")]
    public class AboutController
    {
//        [Route("")]
        public string Phone()
        {
            return "21423";
        }
//        [Route("[action]")]
        public string Address()
        {
            return "Manila";
        }
    }
}
