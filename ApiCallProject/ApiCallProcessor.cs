using ApiCallProject.Models;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace ApiCallProject
{
    public class ApiCallProcessor : IApiCallProcessor
    {
        public async Task<ApiCallInfo> Process()
        {
            string serviceName = "http://www.google.com";
            WebRequest request = WebRequest.Create(serviceName);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var response = (HttpWebResponse)await Task.Factory
            .FromAsync(request.BeginGetResponse,
                            request.EndGetResponse,
                            null);

            stopWatch.Stop();

            var apiCallHistory = new ApiCallInfo
            {
                ServiceName = serviceName,
                CreatedDate = DateTime.Now,
                TimeTaken = stopWatch.Elapsed.TotalMilliseconds
            };

            return apiCallHistory;
        }
    }
}
