using DataAcess;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TestConexion
    {
        public string ProbarConexion(ParametroRequest item) {
            Conexion DA = new Conexion();
            return DA.ProbarConexion(item);
        }

    }
}
