namespace senac_sd_desktop.Classes
{
    public class Pedido
    {
        public string Id { get; set; }
        public string Cliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string Descricao { get; set; }
        public string Hora { get; set; }
        public string Endereco { get; set; }
        public string FormaPagamento { get; set; }
        public double Total { get; set; }
    }
}