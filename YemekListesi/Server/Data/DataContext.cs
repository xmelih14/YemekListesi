using Microsoft.EntityFrameworkCore;
using YemekListesi.Shared;

namespace YemekListesi.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Yemek> Yemeks { get; set; }

    }
}