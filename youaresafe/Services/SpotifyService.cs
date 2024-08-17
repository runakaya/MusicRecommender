using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SpotifyAPI.Web;
using youaresafe.Models;
using youaresafe.Data;
using System.Linq;

namespace youaresafe.Services
{
    public class SpotifyService
    {
        private readonly SpotifySettings _spotifySettings;

        public SpotifyService(IOptions<SpotifySettings> spotifySettings)
        {
            _spotifySettings = spotifySettings.Value;
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

            return "Şarkı önerilemedi.";
        }

        public string GetSpotifyUrl(string trackId)
        {
            return $"https://open.spotify.com/track/{trackId}";
        }

    }
}
