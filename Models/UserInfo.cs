using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Ad alani zorunlu")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Telefon alani zorunlu")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Email alani zorunlu")]
        [EmailAddress(ErrorMessage ="Hatali Email")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Katilim Durumunuzu Belirtin")]
        public bool? WillAttend { get; set; }
    }
}