using BRQ_Truck.Domain;
using Microsoft.EntityFrameworkCore;

namespace BRQ_Truck.Repository
{
    public class LocalDBContext : DbContext
    {
        public LocalDBContext(DbContextOptions<LocalDBContext> options):base(options) {}

        public DbSet<Truck> Truck { get; set; }

        #region Não é necessário agora. Mas, quis deixar por motivo de mudanças mais complexas
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        #endregion
    }
}