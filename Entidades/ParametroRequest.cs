using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParametroRequest
    {
        public string Servidor { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public bool IntegrateSecurity { get; set; }

        public ParametroRequest()
        {
            this.Servidor = "";
            this.Usuario = "";
            this.Clave = "";
            this.IntegrateSecurity = false;
        }
    }
}
