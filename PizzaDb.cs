using Microsoft.EntityFrameworkCore;
using PizzaStore2;

class PizzaDb : DbContext
{
    public PizzaDb(DbContextOptions options) : base(options) { }
    public DbSet<Pizza> Pizzas { get; set; } = null!;
}