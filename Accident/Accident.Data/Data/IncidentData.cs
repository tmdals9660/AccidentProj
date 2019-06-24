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
                                TypeName = x.AccidentType.AccidentTypeName,
                                ViolationName = x.Violation.ViiolationName,
                                RoadFormName2 = x.RoadForm.RoadFormName,
                                AttackerName = x.AttackerType.AttackerTypeName,
                                VictimName = x.VictimType.VictimTypeName
                            };

                var list = query.ToList();

                foreach (var x in list)
                {
                    x.Incident.PartialAccidentFiledName = x.FieldName;
                    x.Incident.PartialAccidentTypeName = x.TypeName;
                    x.Incident.PartialViolationName = x.ViolationName;
                    x.Incident.PartialRoadFormName = x.RoadFormName2;
                    x.Incident.PartialAttackerName = x.AttackerName;
                    x.Incident.PartialVictimName = x.ViolationName;
                }

                return list.ConvertAll(x => x.Incident);

            }
		}
	}
}