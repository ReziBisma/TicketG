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
    public class Ticketgocs : Controller
    {
        public TicketDbContext _context;
        public Ticketgocs(TicketDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string ticketTranportasi, string searchString)
        {
        var tranportasi = _context.Tickets.Select(x => x.Tranportasi).Distinct();
        var tickets = _context.Tickets.AsQueryable();
        if (!string.IsNullOrEmpty(searchString))
        {
        tickets = tickets.Where(s => s.tempatwisata.Contains(searchString));
        }
        if (!string.IsNullOrEmpty(ticketTranportasi))
        {
        tickets = tickets.Where(x => x.Tranportasi == ticketTranportasi);
        }
        var viewModel = new TicketViewModel()
        {
            Tranportasis = new SelectList(await tranportasi.ToListAsync()),
            Tickets = await tickets.ToListAsync()
            };
        return View(viewModel);
        }
    [HttpPost]
     public string Index(string searchString, bool notUsed)
     {
       return "From [HttpPost]Index: filter on " + searchString;
     }
     public IActionResult Detail(int? Id)
        {
            if (Id == null)
        {
            return NotFound();
        }
        var Detail = _context.Tickets.Find(Id);
        if (Detail == null)
        {
            return NotFound();
        }
        return View(Detail);
        }
        public IActionResult Pembelian(int? Id)
        {
            if (Id == null)
        {
            return NotFound();
        }
        var Detail = _context.Tickets.Find(Id);
        if (Detail == null)
        {
            return NotFound();
        }
        return View(Detail);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BeliConfirmed(int id)
        {
            var pembelian = _context.Tickets.Find(id);
            await _context.SaveChangesAsync();
            return RedirectToAction("Pesan");
        }
        public IActionResult Pesan()
        {
            return View();
        }
        [Authorize]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,tempatwisata,Waktu,Tranportasi,Stock, Harga")]Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Tickets.Add(ticket);
                    _context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                return RedirectToAction("Index");
            }
            return View(ticket);
        }
    }   
    }