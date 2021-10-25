using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;



namespace TicketGo.Models
{
    public class Pengguna: IdentityUser
    {
        public List<Transaksi> Transaksi { get; set; }
    }
}