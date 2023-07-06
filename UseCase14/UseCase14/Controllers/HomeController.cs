using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using System.Diagnostics;
using System.Globalization;
using UseCase14.Models;

namespace UseCase14.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index(string culture)
        {
            if (!string.IsNullOrEmpty(culture))
            {
                Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                    new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );
            }

            string numberFormat = _localizer["NumberFormat"];
            string dateFormat = _localizer["DateFormat"];

            CultureInfo cultureInfo = CultureInfo.CurrentCulture;

            ViewBag.Date1 = DateTime.Now.ToString("D", cultureInfo);
            ViewBag.Date2 = DateTime.Now.ToString("f", cultureInfo);
            ViewBag.Date3 = DateTime.Now.ToString("Y", cultureInfo);
            ViewBag.Date4 = DateTime.Now.ToString("dddd", cultureInfo);

            ViewBag.Number1 = 1000000.ToString(numberFormat, CultureInfo.CurrentCulture);
            ViewBag.Number2 = 500000000.ToString(numberFormat, CultureInfo.CurrentCulture);
            ViewBag.Number3 = 150.ToString(numberFormat, CultureInfo.CurrentCulture);
            ViewBag.Number4 = 999999999.ToString(numberFormat, CultureInfo.CurrentCulture);

            ViewBag.LengthText = _localizer["LengthUnitText"];
            ViewBag.LengthUnit = _localizer["LengthUnit"];

            ViewBag.WeightText = _localizer["WeightUnitText"];
            ViewBag.WeightUnit = _localizer["WeightUnit"];

            ViewBag.VolumeText = _localizer["VolumeUnitText"];
            ViewBag.VolumeUnit = _localizer["VolumeUnit"];

            ViewBag.Lang = _localizer["Lang"];
            ViewBag.Measurement = _localizer["Measurement"];
            ViewBag.Date = _localizer["Date"];
            ViewBag.Number = _localizer["Number"];


            var model = new UnitsViewModel();

            return View(model);
        }
    }
}