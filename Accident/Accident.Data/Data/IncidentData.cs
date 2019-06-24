namespace Accident.Data
{
	public class IncidentData : EntityData<Incident>
	{
		public IncidentData()
		{
		}

		public List<Incident> SearchIncident(int? id, DateTime? sdate, DateTime? fdate, int columns)
		{
			using (AccidentEntities context = new AccidentEntities())
			{
				Dictionary<int, string> fieldDict = null;
				if (columns.Has(Incident.IncidentField))
					fieldDict = context.AccidentFileds.ToDictionary(x => x.accidentFieldId, x => x.accidentFieldName);

				var typeDict = context.AccidentTypes.ToDictionary(x => x.accidentTypeId, x => x.accidentTypeName);

				var query = from x in context.Incidents
							where x.Location.cityId == id && x.date <= fdate && x.date >= sdate
							orderby x.date
							select x;

				var list = query.ToList();

				foreach (var x in list)
				{
					x.AccidentFiledName = fieldDict[x.accidentFiledId];
					x.AccidentTypeName = typeDict[x.acidentTypeId];
				}
				return list;
			}
		}

		public List<Incident> SearchIncident2(int? id, DateTime? sdate, DateTime? fdate)
		{
			using (AccidentEntities context = new AccidentEntities())
			{
				var query = from x in context.Incidents
							where x.Location.cityId == id && x.date <= fdate && x.date >= sdate
							orderby x.date
							select new
							{
								Incident = x,
								FieldName = x.AccidentFiled.accidentFieldName,
								TypeName = x.AccidentType.accidentTypeName
							};

				var list = query.ToList();

				foreach (var x in list)
				{
					x.Incident.AccidentFiledName = x.FieldName;
					x.Incident.AccidentTypeName = x.TypeName;
				}

				return list.ConvertAll(x => x.Incident);
			}
		}
	}
}