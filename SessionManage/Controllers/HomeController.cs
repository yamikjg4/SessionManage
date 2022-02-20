using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionManage.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SessionManage.Controllers
{
    public class HomeController : Controller
    {
    private readonly IHttpContextAccessor _https;
    public HomeController(IHttpContextAccessor http)
        {
            _https = http;
        }
     
    public IActionResult setsession()
        {
            _https.HttpContext.Session.SetString("uname","Yamik");
            return View();
        }
        public IActionResult getsession()
        {
            return View();
        }
    }
}
