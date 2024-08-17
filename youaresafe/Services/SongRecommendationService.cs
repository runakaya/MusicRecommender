using System;
using System.Linq;
using System.Threading.Tasks;
using youaresafe.Data;
using youaresafe.Services;
using Microsoft.Extensions.Options;
using SpotifyAPI.Web;
using System.Collections.Generic;
using youaresafe.Models;

namespace youaresafe.Services
{
    public class SongRecommendationService 
    {
        private readonly ApplicationDbContext _context;
        private readonly SpotifySettings _spotifySettings;


        public SongRecommendationService(IOptions<SpotifySettings> spotifySettings, ApplicationDbContext context)
        {
            _spotifySettings = spotifySettings.Value;
            _context = context;
        }

        public async Task<string> GetSongRecommendationAsync()
        {
            var config = SpotifyClientConfig.CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator(_spotifySettings.ClientId, _spotifySettings.ClientSecret));

            var spotify = new SpotifyClient(config);

            var recommendationsRequest = new RecommendationsRequest
            {
                Limit = 1
            };

            recommendationsRequest.SeedGenres.Add("pop"); // List'e öğe eklemek için

            var recommendations = await spotify.Browse.GetRecommendations(recommendationsRequest);

            if (recommendations.Tracks.Count > 0)
            {
                var track = recommendations.Tracks[0];
                return $"{track.Name} by {string.Join(", ", track.Artists.Select(a => a.Name))}";
            }

            return "No recommendations found.";
        }



    }
}
