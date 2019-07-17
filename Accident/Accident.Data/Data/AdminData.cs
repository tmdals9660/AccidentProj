using System.Collections.Generic;
using System.Linq;

namespace Accident.Data
{
    public class AdminData : EntityData<Admin>
    {
        public AdminData()
        {
        }
        public Admin LoginCheck(string id, string password)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Admins
                            where x.AdminIdName.Contains(id) && 
                            x.AdminPassword == password
                            select x;

                if (!query.Any())
                {
                    return null;
                }

                return query.FirstOrDefault();

            }
        }

        public bool UserMakeCheck(Admin admin)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Admins
                            where x.AdminIdName.Contains(admin.AdminIdName)
                            select x;

                if (!query.Any())
                {
                    return true;
                }

                return false;

            }
        }
    }
}
