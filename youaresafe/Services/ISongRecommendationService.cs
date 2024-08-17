using System.Threading.Tasks;

namespace youaresafe.Services
{
    public interface ISongRecommendationService
    {
        Task<string> RecommendSongAsync(string photoUrl);
    }
}
