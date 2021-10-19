using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;
using TicketGo.Data;
using TicketGo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;



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
    }
}