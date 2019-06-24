﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accident.Data
{
	class DB
	{
		static DB()
		{
			Incident = new IncidentData();
			RoadForm = new RoadFormData();
			Location = new LocationData();
			Violation = new ViolationData();
			AccidentFiled = new AccidentFiledData();
			AccidentType = new AccidentTypeData();
			AttackerType = new AttackerTypeData();
			VictimType = new VictimTypeData();
			City = new CityData();
			State = new StateData();
		}

		public static IncidentData Incident { get; }
		public static RoadFormData RoadForm { get; }
		public static LocationData Location { get; }
		public static ViolationData Violation { get; }
		public static AccidentFiledData AccidentFiled { get; }
		public static AccidentTypeData AccidentType { get; }
		public static AttackerTypeData AttackerType { get; }
		public static VictimTypeData VictimType { get; }
		public static CityData City { get; }
		public static StateData State { get; }
	}
}