namespace TelmaBolossite.Entidades
{
    public class Itemencomenda
    {
        public int Id { get; set; }
        public int  EncomendaId { get; set; }
        public Encomenda Encomenda { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }


    }
}
