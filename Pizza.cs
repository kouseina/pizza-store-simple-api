using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Models 
{
    class PizzaDb : DbContext
    {
        public PizzaDb(DbContextOptions options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; } = null!;
    }
    public class Pizza
    {
          public int Id { get; set; }
          public string? Name { get; set; }
          public string? Description { get; set; }
    }
}