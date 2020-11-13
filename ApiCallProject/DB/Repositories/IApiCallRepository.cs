using ApiCallProject.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ApiCallProject.DB.Repositories
{
    public interface IApiCallRepository
    {
        Task<ApiCallInfo> Add(ApiCallInfo apiCallInfo, CancellationToken token);
        Task<List<ApiCallInfo>> GetAll(CancellationToken token);
        Task<ApiCallInfo> GetLast(CancellationToken token);
    }
}
