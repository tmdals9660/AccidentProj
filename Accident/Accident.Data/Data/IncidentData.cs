using System;
using System.Collections.Generic;
using System.Linq;

namespace Accident.Data
{
	public class IncidentData : EntityData<Incident>
	{
		public IncidentData()
		{
		}	

		public List<Incident> SearchIncident2(int? id, DateTime? sdate, DateTime? fdate)
		{
			using (AccidentEntities context = new AccidentEntities())
			{
				var query = from x in context.Incidents
							where x.Location.CityId == id && x.DateAndTime <= fdate && x.DateAndTime >= sdate
							orderby x.DateAndTime
							select new
							{
								Incident = x,
								FieldName = x.AccidentFiled.AccidentFieldName,
								TypeName = x.AccidentType.AccidentTypeName
							};

				var list = query.ToList();

				foreach (var x in list)
				{
					x.Incident. = x.FieldName;
					x.Incident.AccidentTypeName = x.TypeName;
				}

				return list.ConvertAll(x => x.Incident);
			}
		}
	}
}