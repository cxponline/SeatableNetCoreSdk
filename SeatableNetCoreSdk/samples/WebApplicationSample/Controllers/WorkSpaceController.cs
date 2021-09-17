using Microsoft.AspNetCore.Mvc;
using JackieSoft.SeatableNetCoreSdk.Auth;
using JackieSoft.SeatableNetCoreSdk.DTableWeb;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class WorkSpaceController : Controller
    {
        private readonly IWorkSpaceService _workSpaceService;
        private readonly IAuthTokenService _authTokenService;
        public WorkSpaceController(IWorkSpaceService workSpaceService, IAuthTokenService authTokenService)
        {
            this._workSpaceService = workSpaceService;
            this._authTokenService = authTokenService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await this._workSpaceService.GetWorkSpacesAsync("f9adc4547eb03e20607dbf23d6bf169c15b7b219");
            ViewData["data"] = result;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Detail()
        {
            var result = await this._workSpaceService.GetWorkSpacesDetailAsync("f9adc4547eb03e20607dbf23d6bf169c15b7b219");
            ViewData["data"] = result;
            return View();
        }
        public async Task<IActionResult> BaseToken()
        {
            var result = await this._authTokenService.BaseAccessTokenAsync(new JackieSoft.SeatableNetCoreSdk.Domain.SeatableBaseAccessTokenModel
            {
                Token = "f9adc4547eb03e20607dbf23d6bf169c15b7b219",
                WorkSpaceId = 1,
                TableName = "n8nTest"
            });
            ViewData["data"] = result;
            return View();
        }
    }
}
