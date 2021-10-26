using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TicketGo.Models
{
    public class Transaksi
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public string PenggunaId { get; set; }
        public virtual Pengguna Pengguna { get; set; }
        public virtual List<Pembelian> Pembelian { get; set; }   
    }
}