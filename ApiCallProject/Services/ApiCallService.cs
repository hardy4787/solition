using ApiCallProject.DB.Repositories;
using ApiCallProject.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ApiCallProject.Services
{
    public class ApiCallService : IApiCallService
    {
        private readonly IApiCallRepository _apiCallRepository;
        private readonly IApiCallProcessor _apiCallProcessor;

        public ApiCallService(IApiCallRepository apiCallRepository, IApiCallProcessor apiCallProcessor)
        {
            _apiCallRepository = apiCallRepository;
            _apiCallProcessor = apiCallProcessor;
        }

        public async Task<ApiCallInfo> Add(CancellationToken token)
        {
            var apiCallInfo = await _apiCallProcessor.Process();

            return await _apiCallRepository.Add(apiCallInfo, token);
        }

        public async Task<List<ApiCallInfo>> GetAll(CancellationToken token)
        {
            return await _apiCallRepository.GetAll(token);
        }
    }
}
