using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accident.Data.Entities
{
	partial class Incident
	{
		public string ParticalAccidentFiledName { get; set; }

		public string ParticalAccidentTypeName { get; set; }

		public string ParticalAttackerName { get; set; }

		public string ParticalLoadFormName { get; set; }

		public string ParticalVictimName { get; set; }

		public string ParticalViolationName { get; set; }
	}
}
