using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SamplePama.DAL;
using SamplePama.Models;

namespace SamplePama.Controllers
{
    public class HomeController : Controller
    {
        private IPegawai _pegawai;
        private IConfiguration _config;

        public HomeController(IPegawai pegawai,IConfiguration config)
        {
            _pegawai = pegawai;
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pegawai()
        {
            var model = _pegawai.GetAll();
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
