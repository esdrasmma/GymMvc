using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMvc.Controllers
{
    public class MembershipsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
