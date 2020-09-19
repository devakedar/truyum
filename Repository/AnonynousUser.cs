using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using truyum.Models;

namespace truyum.Repository
{
    public class AnonynousUser : IAnonynousUser
    {

        truyumContext db;
        public AnonynousUser(truyumContext _db)
        {
            db = _db;
        }
        public List<MenuItem> GetDetails()
        {
            if (db != null)
            {
                return db.MenuItem.ToList();
            }

            return null;
        }
    }
}
