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
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            var userName = this.RequestContext.Principal.Identity.Name;
            return String.Format("Hello, {0}.", userName);
        }
        //GET api/listClients
        public string ListClients() {
            using (var context = new ApplicationDbContext())
            {
                var clients = context.Database.SqlQuery("SELECT * from dbo.Clients").ToList();
                return clients;
            }
        }
    }
}
