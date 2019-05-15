using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Threading.Tasks;

namespace Functions
{
    public class SignFunctions
    {
        private readonly IConfiguration _configuration;

        public SignFunctions(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        [FunctionName("SignIn")]
        public async Task Run([TimerTrigger("0 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            var authKey = _configuration["AuthToken"];
            var userId = _configuration["UserId"];

            await SignService.Sign(authKey, Convert.ToInt32(userId));
        }
    }
}