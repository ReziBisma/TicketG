using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketGo.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string tempatwisata { get; set; }

        [Display(Name = "Waktu"), DataType(DataType.Date)]
        public DateTime Waktu { get; set; }
       
       [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Tranportasi { get; set; }
        public int Stock { get; set; }
        public int Jumlah {get; set; }

        [Range(50000, 1000000), DataType(DataType.Currency)]
        public decimal Harga { get; set; }
    }
}