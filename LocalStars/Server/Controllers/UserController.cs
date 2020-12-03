using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Models;
using Server.Providers;
using Utils;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserProvider _userProvider;
        private readonly BuyerProvider _buyerProvider;

<<<<<<< HEAD

        public UserController(UserProvider userProvider)
=======
        public UserController(UserProvider userProvider, BuyerProvider buyerProvider)
>>>>>>> db63d2a719b99649cb796fcea8825a94f0bc78f8
        {
            _userProvider = userProvider;
            _buyerProvider = buyerProvider;
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
            var user = _userProvider.AddUser(model.Username, Hash.Sha256(model.Password));
            var buyer = _buyerProvider.Insert(string.Empty, string.Empty);
            _userProvider.LinkToBuyer(user.Id, buyer.Id);
            return await SignIn(new LoginModel { Username = model.Username, Password = model.Password });
        }

        //TODO: add user deletion
    }
}
