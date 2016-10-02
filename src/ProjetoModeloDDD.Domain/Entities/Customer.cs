using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }

        public static bool SpecialCustomer(Customer customer)
        {
            return customer.Active && DateTime.Now.Year - customer.CreatedDate.Year >= 5;
        }
    }
}