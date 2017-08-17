using BusinessLogic;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace guidgenerator.Controllers
{
    public class ConexionController : ApiController
    {
        //public string Get()
        //{
        //    return "hola controlador conexion";
        //}

        public string Get([FromUri]ParametroRequest id)
        {
            TestConexion BL = new TestConexion();
            return BL.ProbarConexion(id);
        }
    }

}
