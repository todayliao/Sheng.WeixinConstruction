﻿using Sheng.WeixinConstruction.Core;
using Sheng.WeixinConstruction.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheng.WeixinConstruction.Management.Shell.Controllers
{
    public class HomeController : BasalController
    {
        private static readonly CachingService _cachingService = CachingService.Instance;

        [AllowedAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            _cachingService.Remove(UserContext.User.Id.ToString());

            SessionContainer.ClearUserContext(this.HttpContext);

            return RedirectToAction("Login");
        }

        [AllowedAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [AllowedAnonymous]
        public ActionResult ResetPassword()
        {
            return View();
        }

      

    }
}