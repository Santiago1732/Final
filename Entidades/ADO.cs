using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ADO
    {
        private string conexion;

        private ADO() { }

        public bool Agregar(Usuario user)
        {
            return true;
        }

        public bool Eliminar(Usuario user)
        {
            return true;
        }

        public bool Modificar(Usuario user) 
        {
            return true;
        }

        public static List<Usuario> ObtenerTodos() 
        {
            List<Usuario> lista = new List<Usuario>();

            return lista;
        }

        public List<Usuario> ObtenerTodos(string apellidoUsuario)
        {
            return null;
        }
    }

    }
