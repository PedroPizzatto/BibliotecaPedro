using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BibliotecaPedro.Performance;
using BibliotecaPedro.Models;

namespace BibliotecaPedro.Controllers
{
    [CompressaoAtributos]
    public class BaseController : Controller
    {
        protected BibliotecaEntities db;

        public BaseController()
        {
           db = new BibliotecaEntities();
        }
    }
}