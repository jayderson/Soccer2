using Soccer.Common.Models;
using System.Threading.Tasks;

namespace Soccer.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);

        Task<bool> CheckConnectionAsync(string url);

        Task<Response> GetTokenAsync(string urlBase, string servicePrefix, string controller, TokenRequest request);

        Task<Response> RegisterUserAsync(string urlBase, string servicePrefix, string controller, UserRequest userRequest);

        Task<Response> GetPredictionsForUserAsync(string urlBase, string servicePrefix, string controller, PredictionsForUserRequest predictionsForUserRequest, string tokenType, string accessToken);

        Task<Response> MakePredictionAsync(string urlBase, string servicePrefix, string controller, PredictionRequest predictionRequest, string tokenType, string accessToken);

    }
}
