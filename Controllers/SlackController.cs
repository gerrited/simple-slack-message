using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace simple_slack_message.Controllers
{
    [Route("api/[controller]")]
    public class SlackController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> GetAsync(string url, string message)
        {
            await new SlackMessageService(url).SendAsync(message);

            return new string[] { message };
        }
    }
}
