using BlazingPizzaApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizzaApp.API.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Pizza> Pizzas { get; set; } = null!;
        public DbSet<PizzaSpecial> Specials { get; set; } = null!;
        public DbSet<PizzaSpecial> PizzaSpecials => Specials;
        public DbSet<PizzaTopping> PizzaToppings { get; set; } = null!;
        public DbSet<Topping> Toppings { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Memaksa nama tabel menjadi 'PizzaSpecials' secara eksplisit
            modelBuilder.Entity<PizzaSpecial>().ToTable("PizzaSpecials");

            // Kunci utama gabungan (Composite Primary Key)
            modelBuilder.Entity<PizzaTopping>()
                .HasKey(pst => new { pst.PizzaId, pst.ToppingId });

            modelBuilder.Entity<PizzaTopping>()
                .HasOne(pst => pst.Pizza)
                .WithMany(ps => ps.Toppings)
                .HasForeignKey(pst => pst.PizzaId);

            modelBuilder.Entity<PizzaTopping>()
                .HasOne(pst => pst.Topping)
                .WithMany()
                .HasForeignKey(pst => pst.ToppingId);
        }
    }
}