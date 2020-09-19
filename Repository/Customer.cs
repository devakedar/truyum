using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using truyum.Models;

namespace truyum.Repository
{
    public class Customer : ICustomer

    {
        truyumContext db;
        public Customer(truyumContext _db)
        {
            db = _db;
        }

        public int AddDetail(MenuItem data)
        {
            if (db != null)
            {
                db.MenuItem.Add(data);
                db.SaveChanges();

                return data.Id;
            }

            return 0;
        }

        public int DeleteDetail(int Id)
        {
            int result = 0;

            if (db != null)
            {

                var post = db.MenuItem.FirstOrDefault(x => x.Id == Id);

                if (post != null)
                {

                    db.MenuItem.Remove(post);
                    result = db.SaveChanges();
                    return 1;
                }
                return result;
            }

            return result;
        }

        public MenuItem GetDetail(int? Id)
        {
            if (db != null)
            {
                return (db.MenuItem.Where(x => x.Id == Id)).FirstOrDefault();
            }
            return null;
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
