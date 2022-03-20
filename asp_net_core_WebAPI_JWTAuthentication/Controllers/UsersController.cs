using asp_net_core_WebAPI_JWTAuthentication.Interface;
using asp_net_core_WebAPI_JWTAuthentication.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace asp_net_core_WebAPI_JWTAuthentication.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IJWTManagerRepository _jWTManager;

        public UsersController(IJWTManagerRepository jWTManager)
        {
            this._jWTManager = jWTManager;
        }

		[HttpGet]
		public List<string> Get()
		{
			var users = new List<string>
		{
			"Satinder Singh",
			"Amit Sarna",
			"Davin Jon"
		};

			return users;
		}

		[AllowAnonymous]
		[HttpPost]
		[Route("authenticate")]
		public IActionResult Authenticate(Users usersdata)
		{
			var token = _jWTManager.Authenticate(usersdata);

			if (token == null)
			{
				return Unauthorized();
			}

			return Ok(token);
		}
	}
}
