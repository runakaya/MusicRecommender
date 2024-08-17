using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace youaresafe.Models
{
    public class PhotoSongRecommendation
    {
        [Key]
        public int RecommendationID { get; set; }

        [Required]
        public int PhotoID { get; set; }

        [Required]
        public int SongID { get; set; }

        public DateTime RecommendedAt { get; set; } = DateTime.Now;

        [ForeignKey("PhotoID")]
        public Photo Photo { get; set; }

        [ForeignKey("SongID")]
        public Song Song { get; set; }
    }
}
