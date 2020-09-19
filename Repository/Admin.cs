using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using truyum.Models;

namespace truyum.Repository
{
    public class Admin : IAdmin
    {
        truyumContext db;
        public Admin(truyumContext _db)
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

        public int UpdateDetail(int id, string MenuItem1)
        {
            if (db != null)
            {
                MenuItem val = db.MenuItem.Where(x => x.Id == id).FirstOrDefault();
               
                if (val != null)
                {
                    db.MenuItem.Remove(val);
                    db.SaveChanges();
                    if ((MenuItem1 != "") && (MenuItem1 != null))
                        val.MenuItem1 = MenuItem1;
                    
                    db.MenuItem.Add(val);
                    db.SaveChanges();
                }
            }
            return 0;
        }
    }
}
