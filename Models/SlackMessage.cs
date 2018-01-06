using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace simple_slack_message.Models {
    public class SlackMessage{
        public string Message { get; set; }

        public string Url { get; set; }
    }
}