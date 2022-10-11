
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaria
{

    internal class Conexion
    {

        public MySqlConnection conex = new MySqlConnection();

        public static string servidor = "162.241.62.45";
        public static string bd = "softteci_primaria";
        private static string usuario = "softteci_softec";
       private  static  string password = "softec1234*";
        public static string puerto = "3306";

          public static string cadena = ("Server=" + servidor + ";Port=" + puerto + ";Database=" + bd + ";Uid=" + usuario +
            ";Pwd=" + password + ";");
        private string infoconexion;
        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadena;
                conex.Open();
            }
            catch (MySqlException e)
            {
                // si el usuario ya existe - el metodo sirve para el registro de usuarios
                if (e.HResult == 1062)
                {
                    MessageBox.Show("El nombre de usuario ya existe");
                }
                //

                else
                    MessageBox.Show("No se pudo establecer conexión al sistema ");


            }

            return conex;

        }

        public MySqlConnection establecerConexion(int n)
        {
            try
            { 
                if(n==2)
                {
                     this.infoconexion = ("Server=" + servidor + ";Port=" + puerto + ";Database=" + bd + ";Uid=director" +
           ";Pwd=director" + ";");
                    conex.ConnectionString = infoconexion;
                }
                if (n == 1)
                {
                    this.infoconexion = ("Server=" + servidor + ";Port=" + puerto + ";Database=" + bd + ";Uid=secretaria" +
          ";Pwd=secretaria" + ";");
                    conex.ConnectionString = infoconexion;
                }
                conex.Open();
            }
            catch (MySqlException e)
            {
                // si el usuario ya existe - el metodo sirve para el registro de usuarios
                if (e.HResult == 1062)
                {
                    MessageBox.Show("El nombre de usuario ya existe");
                }
                //

                else
                    MessageBox.Show("No se pudo establecer la conexion " + e);


            }

            return conex;

        }

        public string ruta()
        {
            return cadena;
        }
      

        public static void consulta(string query)
        {
            Conexion cone = new Conexion();
            MySqlConnection conex = new MySqlConnection(cone.ruta());
            conex.Open();
            MySqlCommand comando = new MySqlCommand(query, conex);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
        }

    }
}
