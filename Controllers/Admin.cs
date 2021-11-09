using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketGo.Data;
using TicketGo.Models;



namespace TicketGo.Controllers
{
    [Authorize]
    [Authorize(Roles = "Admin")]
    public class Admin : Controller
    {
        public TicketDbContext _context;
        public Admin(TicketDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}