using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TicketGo.Models
{
    public class Transaksi
    {
        public int Id { get; set; }
        public string PenggunaId { get; set; }
        public Pengguna Pengguna { get; set; }
        public List<Pembelian> Pembelian { get; set; }   
    }
}