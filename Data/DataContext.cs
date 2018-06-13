using Microsoft.EntityFrameworkCore;
using VIAVAREJO.API.Models;

namespace VIAVAREJO.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Localizazao> Localizacoes {get;set;}
    }
}