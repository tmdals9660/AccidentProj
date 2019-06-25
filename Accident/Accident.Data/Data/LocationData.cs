using System.Collections.Generic;
using System.Linq;

namespace Accident.Data
{
    public class LocationData : EntityData<Location>
    {
        public LocationData()
        {

        }

        public string GetCitiesName(int incidentId)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Locations
                            where x.IncidentId == incidentId
                            select x.City.CityName;

                return query.FirstOrDefault();
            }

        }

        public string GetStateName(int incidentId)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Locations
                            where x.IncidentId == incidentId
                            select x.State.StateName;

                return query.FirstOrDefault();
            }

        }
    }
}
