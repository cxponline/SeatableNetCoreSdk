using Microsoft.AspNetCore.Mvc;
using JackieSoft.SeatableNetCoreSdk.DTableServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class BaseController : Controller
    {
        private readonly IBaseService baseService;
        public BaseController(IBaseService baseService)
        {
            this.baseService = baseService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await this.baseService.GetBaseAsync(new JackieSoft.SeatableNetCoreSdk.Domain.SeatableGetBaseModel
            {
                DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
            });
            ViewData["data"] = result;
            return View();
        }
    }
}
