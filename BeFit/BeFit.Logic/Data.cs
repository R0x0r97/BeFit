using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.Logic
{
    public static class Data
    {
        static Data()
        {
            Controller = new BeFitController();
        }

        public static BeFitController Controller { get; }

    }
}
