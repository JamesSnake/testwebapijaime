using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace DataAcess
{
   public  class Conexion
    {
        public string ProbarConexion(ParametroRequest item) {
            string CadenaConexion = "";
            string Respuesta = "conecto!!!";
            //Integrated Security=SSPI;

            if (item.IntegrateSecurity)
            {
                CadenaConexion = "Data Source = {Servidor}; Initial Catalog = master; Integrated Security = True ";
            }
            else
            {
                CadenaConexion = "Data Source= {Servidor}; Initial Catalog=master; User ID = {Usuario}; Password = {Clave}; ";
            }

            CadenaConexion = CadenaConexion.Replace("{Servidor}", item.Servidor);
            CadenaConexion = CadenaConexion.Replace("{Usuario}", item.Usuario);
            CadenaConexion = CadenaConexion.Replace("{Clave}", item.Clave);

            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = CadenaConexion;
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                Respuesta = "error : " + ex.Message + " detalle : " + ex.InnerException.Message ;
            }
            
            return Respuesta;
        }
    }
}
