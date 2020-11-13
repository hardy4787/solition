using ApiCallProject.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ApiCallProject.Services
{
    public interface IApiCallService
    {
        Task<ApiCallInfo> Add(CancellationToken token);
        Task<List<ApiCallInfo>> GetAll(CancellationToken token);
    }
}
