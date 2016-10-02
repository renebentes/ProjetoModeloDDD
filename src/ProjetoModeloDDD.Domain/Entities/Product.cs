namespace ProjetoModeloDDD.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}