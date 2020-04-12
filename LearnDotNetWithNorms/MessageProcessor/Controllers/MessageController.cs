using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageProcessor.Handler;
using Microsoft.AspNetCore.Mvc;

namespace MessageProcessor.Controllers
{
    [Route("")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageHandler _messageHandler;

        public MessageController(IMessageHandler messageHandler)
        {
            _messageHandler = messageHandler;
        }
        // GET api/values
        [HttpGet("")]
        public async Task<ActionResult> Get()
        {
            return Content(await _messageHandler.Run());
        }

    }
}
