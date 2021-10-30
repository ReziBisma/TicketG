using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;



namespace TicketGo.Models
{
    public class Pengguna: IdentityUser
    {
        public string Name {get; set;}
        public string Avatar { get; set; }

        public virtual List<Transaksi> Transaksis { get; set; }
    }
}