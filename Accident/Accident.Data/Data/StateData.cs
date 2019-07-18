using System;
using System.Collections.Generic;
using System.Linq;

namespace Accident.Data
{
	public class StateData : EntityData<State>
	{
		public StateData()
		{

		}

        public List<State> CityValues(int cityId)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                var query = from x in context.States
                            where x.CityId == cityId
                            select x;

                List<State> states = query.ToList();

                return states;

            }
        }
    }
}