﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;


namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class PivotViewController : Controller
    {

        public IActionResult LocalData()
        {
            ViewBag.data = new PivotViewData().GetrenewableEnergy();
            ViewBag.drilledMembers = new string[] { "Biomass", "Free Energy" };
            return View();
        }
    }
}
