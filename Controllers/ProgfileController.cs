using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Logging;
using TicketGo.Models;

namespace TicketGo.Controllers
{
    [Route("[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly UserManager<Pengguna> _userManager;

        public ProfileController(ILogger<ProfileController> logger, UserManager<Pengguna> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{fileName}")]
        public async Task<IActionResult> Avatar(string fileName)
        {
            var avatarFile = Path.Combine(Directory.GetCurrentDirectory(), "Avatars", fileName);
            new FileExtensionContentTypeProvider().TryGetContentType(avatarFile, out var contentType);
            return File(await System.IO.File.ReadAllBytesAsync(avatarFile), contentType ?? "application/octet-stream");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}