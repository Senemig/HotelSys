using System.Collections.Generic;

namespace HotelSys.Models
{
    public class ViewModel
    {
        public List<Cliente> Clientes = new List<Cliente>();
        public List<Quarto> Quartos = new List<Quarto>();

        public int idQuarto { get; set; }
        public int idCliente { get; set; }

        public Quarto quarto { get; set; }
        public Cliente cliente { get; set; }

    }
}