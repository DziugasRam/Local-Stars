using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Models;
using Server.Exceptions;
using Server.Providers;
using Utils;


namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserProvider _userProvider;

        public UserController(UserProvider userProvider)
        {
            _userProvider = userProvider;
        }

        [HttpPost]
        [Route("signin")]
        [AllowAnonymous]
        public async Task<StatusCodeResult> SignIn(LoginModel model)
        {
            var user = _userProvider.GetUser(model.Username, Hash.Sha256(model.Password));
            if (user == null)
                return new StatusCodeResult(StatusCodes.Status401Unauthorized);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties { IsPersistent = true });
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        [HttpPost]
        [Route("signout")]
        [AllowAnonymous]
        public async Task<StatusCodeResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public async Task<StatusCodeResult> Register(RegisterModel model)
        {
            try
            {
                _userProvider.AddUser(model.Username, Hash.Sha256(model.Password));
            }
            catch (ConflictException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return await SignIn(new LoginModel { Username = model.Username, Password = model.Password });
        }

        //TODO: add user deletion
    }
}
