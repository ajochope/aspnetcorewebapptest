using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppList.API.Controllers
{
    public class FallBack : Controller
    {
        public IActionResult Index()
        {
            return PhysicalFile(
                Path.Combine(
                    Directory.GetCurrentDirectory(), 
                    "wwwroot", "index.html"), "text/HTML");
        }
    }
}
