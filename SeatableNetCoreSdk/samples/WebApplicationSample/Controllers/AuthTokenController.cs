using Microsoft.AspNetCore.Mvc;
using JackieSoft.SeatableNetCoreSdk.Auth;
using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Threading.Tasks;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class AuthTokenController : Controller
    {
        private readonly IAuthTokenService _authTokenService;

        public AuthTokenController(IAuthTokenService authTokenService)
        {
            this._authTokenService = authTokenService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AuthToken(AuthViewModel viewModel)
        {
            var model = new SeatableAuthModel
            {
                UserName = viewModel.UserName,
                Password = viewModel.Password
            };
            var result = await this._authTokenService.AuthTokenAsync(model);
            ViewData["response"] = result.Token;
            return View();
        }        
    }
}
