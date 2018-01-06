using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using simple_slack_message.Models;
using simple_slack_message.Services;

namespace simple_slack_message.Controllers
{
    [Route("api/[controller]")]
    public class SlackController : Controller
    {
        // // GET api/slack
        // [HttpGet]
        // public async Task<IEnumerable<string>> GetAsync(string url, string message)
        // {
        //     await new SlackMessageService(url).SendAsync(message);

        //     return new string[] { message };
        // }

        // POST api/slack
        [HttpPost]
        public async Task<StatusCodeResult> CreateAsync(SlackMessage item)
        {
            if (item == null)
                return BadRequest();

            await new SlackMessageService(item.Url).SendAsync(message: item.Message);

            return StatusCode(201);
        }
    }
}
