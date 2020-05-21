namespace BeFit.Model.DBContext
{
    using System.Data.Entity;
    using BeFit.Model;
    public class BeFitDB : DbContext
    {
        public BeFitDB():
            base("name=BeFitDB")
        { }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Entry> Entries { get; set; }

        public virtual DbSet<Ticket> Sales { get; set; }

        public virtual DbSet<TicketType> Types { get; set; }

        public virtual DbSet<User> Users { get; set; }
    }
}
