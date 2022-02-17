using System.ComponentModel.DataAnnotations;

namespace PlayersAPI.Models
{
    public class Club
    {
        [Key]
        public int ClubID { get; set; }
        [Required]
        [StringLength(100)]
        public string ClubName { get; set; }
        [StringLength(100)]
        public string ManagerName { get; set; }
        [StringLength(100)]
        public string League { get; set; }
    }
}
