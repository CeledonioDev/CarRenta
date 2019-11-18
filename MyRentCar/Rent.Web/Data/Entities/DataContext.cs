using Microsoft.EntityFrameworkCore;

namespace Rent.Web.Data.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<TiposVehiculos> TiposVehiculos { get; set; }

        public DbSet<ModeloVehiculo> ModeloVehiculos { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        public DbSet<MarcaVehiculo> MarcaVehiculos { get; set; }

        public DbSet<VehiculoCaracteristica> VehiculoCaracteristicas { get; set; }

        public DbSet<VehiculoPublicacion> vehiculoPublicacions { get; set; }
    }
}