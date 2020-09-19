using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using truyum.Models;

namespace truyum.Repository
{
    public interface IAnonynousUser
    {
        List<MenuItem> GetDetails();
    }
}
