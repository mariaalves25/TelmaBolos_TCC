namespace TelmaBolossite.Entidades
{
    public class Encomenda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set;}

        public DateTime dataencomenda { get; set; }
        public DateTime dataretirada { get; set; }

        
    }
}
