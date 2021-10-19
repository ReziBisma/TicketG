using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TicketGo.Models;


namespace TicketGo.Models
{
    public class TicketViewModel
    {
        public List<Ticket> Tickets { get; set; }
        public SelectList Tranportasis { get; set; }
        public string TicketTranportasi { get; set; }
        public string SearchString { get; set; }
    }
}