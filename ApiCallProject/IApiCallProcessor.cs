using ApiCallProject.Models;
using System.Threading.Tasks;

namespace ApiCallProject
{
    public interface IApiCallProcessor
    {
        Task<ApiCallInfo> Process();
    }
}
