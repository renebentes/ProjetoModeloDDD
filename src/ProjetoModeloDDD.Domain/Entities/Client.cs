using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public bool SpecialClient(Client client)
        {
            return client.Active && DateTime.Now.Year - client.CreatedDate.Year >= 5;
        }
    }
}