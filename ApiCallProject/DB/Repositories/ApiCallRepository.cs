using ApiCallProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ApiCallProject.DB.Repositories
{
    public class ApiCallRepository : IApiCallRepository
    {
        private readonly ApplicationContext _db;
        public ApiCallRepository(ApplicationContext context)
        {
            _db = context;
        }
        public async Task<ApiCallInfo> Add(ApiCallInfo apiCallInfo, CancellationToken token)
        {
            _db.ApiCallHistories.Add(apiCallInfo);

             await _db.SaveChangesAsync();

            return apiCallInfo;
        }

        public async Task<List<ApiCallInfo>> GetAll(CancellationToken token)
        {
            return await _db.ApiCallHistories.ToListAsync();
        }

        public async Task<ApiCallInfo> GetLast(CancellationToken token)
        {
            return await _db.ApiCallHistories.LastAsync();
        }
    }
}
