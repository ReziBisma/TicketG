using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketGo.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string tempatwisata { get; set; }

        [DataType(DataType.Date)]
        public DateTime Waktu { get; set; }
        public string Tranportasi { get; set; }
        public int Stock { get; set; }
        public decimal Harga { get; set; }
        public Ticket Tiket {get; set;}
    }
}