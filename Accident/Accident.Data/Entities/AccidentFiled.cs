using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accident.Data.Entities
{
	partial class Incident
	{
		public string AccidentFiledName { get; set; }

		public string AccidentTypeName { get; set; }

		public string AttackerName { get; set; }

		public string LoadFormName { get; set; }

		public string VictimName { get; set; }

		public string ViolationName { get; set; }
	}
}
