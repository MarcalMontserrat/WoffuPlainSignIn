using System;
using System.Collections.Generic;
using System.Linq;
using Functions.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Service
{
    public static class SignService
    {
        public static async Task Sign(string authToken, int userId)
        {
            var uri = "https://plainconcepts.woffu.com/api/signs";

            var httpClient = new HttpClient();
            var message = new HttpRequestMessage(HttpMethod.Post, uri);
            var body = JsonConvert.SerializeObject(new Message(userId));

            message.Content = new StringContent(body, Encoding.UTF8, "application/json");
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {authToken}");
            await httpClient.SendAsync(message);
        }
    }
}
