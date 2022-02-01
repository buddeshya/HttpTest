using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {

            var stringTask = client.GetStringAsync("https://610f9bb5-87d7-4245-ad67-02038d5fe90d.mock.pstmn.io/Agent/getTime");


            var msg = await stringTask;
            Console.Write(msg);

        }
    }
}
