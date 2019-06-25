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

        public List<Incident> SearchIncident2(int? id)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                context.Database.Log = x => Debug.WriteLine(x);

                var query = from x in context.Incidents
                            orderby x.DateAndTime
                            let location = x.Location
                            select new
                            {
                                Incident = x,
                                LocationId = location,
                                FieldName = x.AccidentFiled.AccidentFieldName,
                                TypeName = x.AccidentType.AccidentTypeName,
                                ViolationName = x.Violation.ViiolationName,
                                RoadFormName2 = x.RoadForm.RoadFormName,
                                AttackerName = x.AttackerType.AttackerTypeName,
                                VictimName = x.VictimType.VictimTypeName,
                                CityName = location.City.CityName,
                                StateName = location.State.StateName
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