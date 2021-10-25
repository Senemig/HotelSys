namespace HotelSys.Models
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string[] Telefone { get; set; }
        public string[] Endereço { get; set; }
    }
}