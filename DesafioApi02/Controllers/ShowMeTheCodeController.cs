using DesafioApi02.Model;
using DesafioApi02.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowMeTheCodeController
    {
        public ShowMeTheCodeController()
        {
        }

        [HttpGet]
        [Route("/showmethecode")]
        public ActionResult<ShowMeTheCode> Get()
        {
            return ShowMeTheCodeService.GetUrlsGithub();
        }
    }
}
