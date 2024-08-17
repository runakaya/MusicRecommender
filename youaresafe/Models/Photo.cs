using System;

namespace youaresafe.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }
        public string SongRecommendation { get; set; }
        public DateTime UploadedAt { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
      
    }
}

