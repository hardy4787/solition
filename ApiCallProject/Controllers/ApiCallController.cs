using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ApiCallProject.Models;
using ApiCallProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiCallProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiCallController : ControllerBase
    {
        private readonly IApiCallService _apiCallService;
        public ApiCallController(IApiCallService apiCallService)
        {
            _apiCallService = apiCallService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApiCallInfo>>> GetAll(CancellationToken token)
        {
            return await _apiCallService.GetAll(token);
        }

        [HttpPost]
        public async Task<ActionResult<ApiCallInfo>> Post(CancellationToken token)
        {
            return await _apiCallService.Add(token);
        }
    }
}
