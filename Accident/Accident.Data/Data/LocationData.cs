using System.Collections.Generic;
using System.Linq;

namespace Accident.Data
{
	public class LocationData : EntityData<Location>
	{
		public LocationData()
		{

		}


		public List<int> Search(int incId)
		{
			using (AccidentEntities context = new AccidentEntities())
			{
				return context.Locations.Select(x => x.IncidentId).ToList();
			}
		}
	}
}