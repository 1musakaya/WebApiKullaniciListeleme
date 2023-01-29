using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Uygulama.Controllers
{
    public class DepartmanController:ApiController
    {
        webApiEntities _ent = new webApiEntities();

        [HttpGet]
        public List<TblDepartman> TumPersonelleriGetir()
        {
            return _ent.TblDepartman.ToList();
        }
    }
}