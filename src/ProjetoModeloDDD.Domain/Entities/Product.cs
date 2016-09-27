namespace ProjetoModeloDDD.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}