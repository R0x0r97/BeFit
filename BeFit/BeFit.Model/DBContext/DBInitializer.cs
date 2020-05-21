using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.Model.DBContext
{
    public class DBInitializer : CreateDatabaseIfNotExists<BeFitDB>
    {
        protected override void Seed(BeFitDB context)
        {
            AddData(context);
        }

        private void AddData(BeFitDB context)
        {
            context.Types.Add(new TicketType { Id = 0, isDeleted = false, Name = "Type1", Price = 10, LengthInDays = 30, TimesUsable = null });
            context.Types.Add(new TicketType { Id = 1, isDeleted = false, Name = "Type2", Price = 18, LengthInDays = 60, TimesUsable = null });
            context.Types.Add(new TicketType { Id = 2, isDeleted = false, Name = "Type3", Price = 10, LengthInDays = null, TimesUsable = 20 });

            context.Users.Add(new User { Id = 0, Email = "asd@asd.asd", IsAdmin = true, Name = "Local Police", Password = "12345", PhoneNumber = "0123456789" });
        }
    }
}
