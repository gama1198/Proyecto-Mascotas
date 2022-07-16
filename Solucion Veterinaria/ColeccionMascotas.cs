using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioMascota
{
    public class ColeccionMascotas
    {
        // crear una coleccion en memoria donde
        // se guardaran los objetos de tipo Mascota
        static List<Mascota> coleccion = new List<Mascota>();

        // operaciones sobre el grupo de objetos:
        public static bool Agregar(Mascota nueva)
        {
            if (BuscarId(nueva.Id) == null)
            {
                coleccion.Add(nueva);
                return true;
            } else
            {
                return false;
            }
        }
        public static bool Modificar(Mascota mascota)
        {
            // buscar el id de la mascota a reemplazar
            for (int i = 0; i < coleccion.Count; i++)
            {
                if(coleccion[i].Id == mascota.Id)
                {
                    coleccion[i] = mascota;
                    return true;
                }
            }

            return false;
        }

        public static bool Eliminar(int idEliminar)
        {
            Mascota mascota = BuscarId(idEliminar);
            if(mascota != null)
            {
                // cuando la mascota existe
                coleccion.Remove(mascota);
                return true;
            }
            return false;
        }
        public static Mascota BuscarId(int idBuscado)
        {
            // buscar el id dentro de la coleccion
            // si existe devolvemos el objeto con sus datos
            // si no existe, devolvemos null
            for (int i = 0; i < coleccion.Count; i++)
            {
                if(coleccion[i].Id == idBuscado)
                {
                    return coleccion[i];
                }
            }
            // nunca encontró el if
            return null;
        }
        public static List<Mascota> ListarTodas()
        {
            List<Mascota> lista = new List<Mascota>();
            // llenar la lista con los datos guardados
            for (int i = 0; i < coleccion.Count; i++)
            {
                lista.Add(coleccion[i]);
            }
            return lista;
        }

    }
}
