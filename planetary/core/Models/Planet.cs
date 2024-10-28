using planetary.core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetary.core.Models
{
    internal class Planet
    {
        public Planet(string planetName)
        {
            PlanetName = planetName;
        }

        public int PlanerId { get; set; }
        public string PlanetName { get; set; }
        public string Area { get; set; }

        
    }
}
