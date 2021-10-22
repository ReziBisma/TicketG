using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace TicketGo.Models
{
    public class Pengguna
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Password {get; set;}
        public List<Transaksi> Transaksi { get; set; }
    }
}