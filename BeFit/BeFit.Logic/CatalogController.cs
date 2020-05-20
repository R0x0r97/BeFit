// ------------------------------------------------------------------------------------------------------------------
// <copyright file="CatalogController.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Szilveszter Gorgicze</author>
// ------------------------------------------------------------------------------------------------------------------

namespace BeFit.Logic
{
    using System.Collections.Generic;
    using System.Linq;
    using BeFit.Model.DBContext;

    public class BeFitController
    {
        private BeFitDB beFitDatabase;

        public BeFitController()
        {
            this.beFitDatabase = new BeFitDB();
        }

        /*public List<Manufacturer> GetManufacturers()
        {
            return this.catalogDatabase.Manufacturer.ToList();
        }*/
    }
}
