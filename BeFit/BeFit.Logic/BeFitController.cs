// ------------------------------------------------------------------------------------------------------------------


namespace BeFit.Logic
{
    using System.Collections.Generic;
    using System.Linq;
    using BeFit.Model;
    using BeFit.Model.DBContext;

    public class BeFitController
    {
        private BeFitDB beFitDatabase;

        public BeFitController()
        {
            this.beFitDatabase = new BeFitDB();
        }

        public List<User> GetUsers()
        {
            return beFitDatabase.Users.ToList();
        }
    }
}
