using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gao.Libre.GameMasterEmulation.Mechanic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gao.Web.Areas.GameMasterEmulator.Controllers
{
    [Area("GameMasterEmulator")]
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var mission = MissionFactory.GenerateMission();
            return View(mission);
        }
    }
}