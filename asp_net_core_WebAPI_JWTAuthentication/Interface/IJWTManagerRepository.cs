using asp_net_core_WebAPI_JWTAuthentication.Model;

namespace asp_net_core_WebAPI_JWTAuthentication.Interface
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
