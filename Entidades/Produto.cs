namespace TelmaBolossite.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string descricaoproduto { get; set; }
        public string valorproduto { get; set; }
        public string unidadeproduto { get; set; }
        public string imagem { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
