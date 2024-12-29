using System.ComponentModel.DataAnnotations;

namespace RefreshTokenDemo
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}
