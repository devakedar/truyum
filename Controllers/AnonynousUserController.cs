using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using truyum.Models;

namespace truyum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnonynousUserController : ControllerBase
    {
         

        // GET: api/AnonynousUser
        [HttpGet]
        public IEnumerable<MenuItem> GetMenuItems()

        {
            using (truyumContext context = new truyumContext())
                if (context != null)
                {
                    return context.MenuItem.ToList();
                }
            return null;
        }

       

       
    }
}
