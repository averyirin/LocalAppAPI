using LocalAccountsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocalAccountsApp.Controllers
{
    [Authorize]
    [RoutePrefix("api/Clients")]
    public class ClientController : ApiController
    {

        // GET api/Clients
        public object Get()
        {
            using (var context = new ApplicationDbContext())
            {
                var clients = context.Database.SqlQuery<object>("SELECT * from dbo.Clients").ToList();
                return clients;
            }
        }
        
    }
}
