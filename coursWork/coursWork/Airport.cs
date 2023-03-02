using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursWork
{
    internal class Airport
    {

        private string airportFullName;
        private string airportName;
        private string airportCountry;

        public Airport(string airportFullName, string airportName, string airportCountry)
        {
            this.airportFullName = airportFullName;
            this.airportName = airportName;
            this.airportCountry = airportCountry;
        }

        public string GetFullName() { return airportFullName; }
        public string GetName() { return airportName; }
        public string GetCountry() { return airportCountry; }
    }
}
