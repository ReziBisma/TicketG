using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace TicketGo.Models
{
    public class Pembelian
    {
        public int Id { get; set; }
        public string Name {get; set; }
        public string TicketId { get; set; }
        public virtual Ticket Tiket {get; set;}
        public int TransaksiId {get; set;}
        public virtual Transaksi transaksi {get; set;}
        public int Jumlah {get; set;}
        public int Harga {get; set;}
        public virtual List<Ticket> Ticket {get; set;}
    }
}