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

    }
}
