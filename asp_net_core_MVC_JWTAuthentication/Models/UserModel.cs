using System.ComponentModel.DataAnnotations;

namespace asp_net_core_MVC_JWTAuthentication.Models
{
    public class UserModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
