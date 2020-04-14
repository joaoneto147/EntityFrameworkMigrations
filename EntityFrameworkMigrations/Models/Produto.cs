using System;

namespace EntityFrameworkMigrations.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Double Price { get; set; }
        public String Marca { get; set; }
    }
}
