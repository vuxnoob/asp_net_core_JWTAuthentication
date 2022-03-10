using asp_net_core_MVC_JWTAuthentication.DTO;

namespace asp_net_core_MVC_JWTAuthentication.Interface
{
    public interface ITokenService
    {
        public string BuildToken(string key, string issuer, UserDTO user);
        public bool ValidateToken(string key, string issuer, string token);
    }
}
