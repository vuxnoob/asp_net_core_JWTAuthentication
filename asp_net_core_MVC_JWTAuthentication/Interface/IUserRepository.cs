using asp_net_core_MVC_JWTAuthentication.DTO;
using asp_net_core_MVC_JWTAuthentication.Models;

namespace asp_net_core_MVC_JWTAuthentication.Interface
{
    public interface IUserRepository
    {
        public UserDTO GetUser(UserModel userMode);
    }
}
