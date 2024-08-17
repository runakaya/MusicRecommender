using System.ComponentModel.DataAnnotations;
using System;

namespace youaresafe.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Artist { get; set; }

        [StringLength(100)]
        public string Album { get; set; }

        [StringLength(50)]
        public string Genre { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string SpotifyUrl { get; set; }
    }
}
