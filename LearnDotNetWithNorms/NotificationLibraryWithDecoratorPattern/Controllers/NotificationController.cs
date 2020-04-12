using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NotificationLibraryWithDecoratorPattern.Controllers
{
    [Route("")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        // GET api/values
        [HttpGet("")]
        public ActionResult Get()
        {
            return Ok("Notification service runnig...");
        }

       
    }
}
