namespace BeFit.Model.DBContext
{
    using System.Data.Entity;
    using BeFit.Model;
    public class BeFitDB : DbContext
    {
        public BeFitDB() { }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Login> Logins { get; set; }

        public virtual DbSet<Sale> Sales { get; set; }

        public virtual DbSet<Type> Types { get; set; }

        public virtual DbSet<User> Users { get; set; }
    }
}
