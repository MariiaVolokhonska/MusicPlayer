using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicPlayer.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required]
        public string Login{ get; set; }
        [Required]
        [StringLength(20, MinimumLength =8)]
        public string Password { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Wrong email address.")]
        public string? Email { get; set; }
        [Required]
        [RegularExpression(@"\d{9}",ErrorMessage ="Wrong number format.It should be like 000000000.")]
        public string? PhoneNumber { get; set; }
        public List<Playlist> Playlists { get; set; }


    }
}
