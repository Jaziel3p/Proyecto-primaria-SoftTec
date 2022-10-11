using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primaria
{
    public class Usuario
    {
        private string nombre;
        private int ID;
        private bool director;
        private string rol;
        Conexion conex = new Conexion();  
        public Usuario(string nombre, int ID , bool privi)
        {
            this.nombre = nombre;
            this.ID = ID;
            this.director = privi;
            if (privi)
            {
                rol = "Director";
            }
            else
            {
                rol = "Secretaria";
            }
        }


        public bool getPrivilegio() => director;

        public int getID()
        {
            return ID;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getRol()
        {
           
                return rol;
        }

    }
}
