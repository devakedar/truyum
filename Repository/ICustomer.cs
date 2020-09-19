using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using truyum.Models;

namespace truyum.Repository
{
    public interface ICustomer
    {
        List<MenuItem> GetDetails();
        MenuItem GetDetail(int? Id);
        int AddDetail(MenuItem data);
        int DeleteDetail(int Id);
       
    }
}
