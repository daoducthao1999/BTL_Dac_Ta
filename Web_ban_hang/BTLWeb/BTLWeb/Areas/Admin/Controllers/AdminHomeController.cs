﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLWeb.Areas.Admin.Controllers
{
    public class AdminHomeController : BaseController
    {
        // GET: Admin/Home
       
        public ActionResult Index()
        {
            return View();
        }
    }
}