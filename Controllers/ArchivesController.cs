﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NetCoreTest1.Controllers
{
    public class ArchivesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
