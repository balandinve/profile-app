using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using profile.data;
using profile.services;
using profile_app.web.Models;

namespace profile_app.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProfileService _profileService;
        private readonly ICityService _cityService;

        public HomeController(ILogger<HomeController> logger, IProfileService profileService, ICityService cityService)
        {
            _logger = logger;
            _profileService = profileService;
            _cityService = cityService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult ProfileForm()
        {
            try
            {
                var profile = new ProfileDTO();
                var cities = _cityService.GetAll().Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Title
                });
                ViewBag.Cities = cities;
                return View(profile);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("ProfileError","Ошибка при инициализиции формы.");
            }
        }
        [HttpPost]
        public IActionResult ProfileForm(ProfileDTO profile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    profile.Id = _profileService.Add(profile);
                    return View("ProfileSuccess", profile.FullName);
                }
                catch(Exception ex)
                {
                    _logger.LogError(ex, ex.Message);
                    return View("ProfileError", "Ошибка при добавлении профиля.");
                }
            }
            return View(profile);
        }
    }
}
