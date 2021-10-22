using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace TicketGo.Models
{
    public class Pembelian
    {
        public int Id { get; set; }
        public string TicketId { get; set; }
        public Ticket Tiket {get; set;}
        public int TransaksiId {get; set;}
        public Transaksi transaksi {get; set;}
        public int Jumlah {get; set;}
        public int Harga {get; set;}

        public List<Transaksi> Transaksi { get; set; }
        public List<Ticket> Ticket {get; set;}
    }
}