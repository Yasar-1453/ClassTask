using planetary.core.Enums;
using planetary.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace planetary
{
    internal class AppDbContext
    {
        List<Country> Countries = new List<Country>();
        List<Planet> Planets = new List<Planet>();

        public void CreatCountry(Country country)
        {
            Countries.Add(country);
        }

        public void UpdateCountry(Country country)
        {
            var nCountry = Countries.FirstOrDefault(x => x.CountryId == country.CountryId);
            if (nCountry != null)
            {
                nCountry.CountryId = country.CountryId;
                nCountry.CountryName = country.CountryName;
                nCountry.Anthem = country.Anthem;
                nCountry.Area = country.Area;
                nCountry.Region = country.Region;
            }
        }

        public void RemoveCountry(Country country)
        {
            foreach (var nCountry in Countries)
            {
                if (nCountry.CountryId == country.CountryId)
                {

                    Countries.Remove(country);
                }
            }
        }

        public void CreatPlanet(Planet planet)
        {
            Planets.Add(planet);
        }

        public void RemovePlanet(Planet planet)
        {
            foreach (Planet p in Planets)
            {
                if (p.PlanerId == planet.PlanerId)
                {

                    Planets.Remove(planet);
                }
            }
        }

        public void GetCountryByRegion(Region region)
        {
            Countries.Find(x => x.Region == region);
        }

        public List<Country> GetAllCountries()
        {
            return Countries;
        }

        public List<Planet> GetAllPlanets()
        {
            return Planets;
        }
    }
}
