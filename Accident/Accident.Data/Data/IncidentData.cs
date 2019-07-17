using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Accident.Data
{
    public class IncidentData : EntityData<Incident>
    {
        public IncidentData()
        {
        }
        public string GetCitiesName(int incidentId)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Incidents
                            where x.IncidentId == incidentId
                            select x.City.CityName;

                return query.FirstOrDefault();
            }

        }

        public string GetStateName(int incidentId)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Incidents
                            where x.IncidentId == incidentId
                            select x.State.StateName;

                return query.FirstOrDefault();
            }

        }
        public List<Incident> SearchIncident(int? id, DateTime? sdate, DateTime? fdate)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Incidents
                            where x.DateAndTime <= fdate && x.DateAndTime >= sdate
                            orderby x.DateAndTime
                            select new
                            {
                                Incident = x,
                                FieldName = x.AccidentFiled.AccidentFieldName,
                                TypeName = x.AccidentType.AccidentTypeName,
                                ViolationName = x.Violation.ViiolationName,
                                RoadFormName2 = x.RoadForm.RoadFormName,
                                AttackerName = x.AttackerType.AttackerTypeName,
                                VictimName = x.VictimType.VictimTypeName,
                                CityName = x.City.CityName,
                                StateName = x.State.StateName
                            };

                if (id.HasValue)
                    query = query.Where(x => x.Incident.CityId == id);

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