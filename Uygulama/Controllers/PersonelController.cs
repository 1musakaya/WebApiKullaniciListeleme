using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Uygulama.Controllers
{
    public class PersonelController:ApiController
    {
        webApiEntities _ent = new webApiEntities();

        [HttpGet]
        public List<TblPersonel> TumPersonelleriGetir()
        {
            return _ent.TblPersonel.ToList();
        }
    }
}