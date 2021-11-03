using System;

namespace HotelSys.Models
{
    public class Historico
    {
        public int idHistorico { get; set; }
        public int Quarto { get; set; }
        public int idCliente { get; set; }
        public string Tipo { get; set; }
        public DateTime Registro { get; set; }
    }
}