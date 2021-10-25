using System;

namespace HotelSys.Models
{
    public class Quarto
    {
        public int idQuarto { get; set; }
        public int Numero { get; set; }
        public string Status { get; set; }
        public string Descricao { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public Cliente cliente { get; set; }
    }
    }
