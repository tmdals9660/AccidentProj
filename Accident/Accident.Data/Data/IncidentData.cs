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

        public List<Incident> SearchIncident(int? id, DateTime? sdate, DateTime? fdate)
        {
            using (AccidentEntities context = new AccidentEntities())
            {
                var query = from x in context.Incidents
                            where x.DateAndTime <= fdate && x.DateAndTime >= sdate
                            orderby x.DateAndTime
                            select new
                            {
                                Incident = x,
                                LocationId = x.Location,
                                FieldName = x.AccidentFiled.AccidentFieldName,
                                TypeName = x.AccidentType.AccidentTypeName,
                                ViolationName = x.Violation.ViiolationName,
                                RoadFormName2 = x.RoadForm.RoadFormName,
                                AttackerName = x.AttackerType.AttackerTypeName,
                                VictimName = x.VictimType.VictimTypeName,
                                CityName = x.Location.City.CityName,
                                StateName = x.Location.State.StateName
                            };

                if (id.HasValue)
                    query = query.Where(x => x.LocationId.CityId == id);

                var list = query.ToList();

                foreach (var x in list)
                {
                    x.Incident.PartialAccidentFiledName = x.FieldName;
                    x.Incident.PartialAccidentTypeName = x.TypeName;
                    x.Incident.PartialViolationName = x.ViolationName;
                    x.Incident.PartialRoadFormName = x.RoadFormName2;
                    x.Incident.PartialAttackerName = x.AttackerName;
                    x.Incident.PartialVictimName = x.VictimName;
                    x.Incident.PartialCity = x.CityName;
                    x.Incident.PartialState = x.StateName;
                }

                return list.ConvertAll(x => x.Incident);

            }
        }

    }
}