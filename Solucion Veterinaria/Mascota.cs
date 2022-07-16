using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioMascota
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public bool Vacunado { get; set; }
        public DateTime FechaNacim { get; set; }

        public void ImprimirFicha()
        {
            Console.WriteLine("Datos Mascota");
            Console.WriteLine("Id: " + Id);
        }

        public string Datos()
        {
            string msg = "";
            msg += "-----------------\n";
            msg += "     FICHA\n";
            msg += "-----------------\n";
            msg += "\nID     : " + Id;
            msg += "\nNOMBRE : " + Nombre;
            msg += "\nRAZA   : " + Raza;
            msg += "\nEDAD   : " + Edad;
            msg += "\nSEXO   : " + Sexo;
            msg += "\nVACUNAS: " + Vacunado;
            msg += "\nFEC NAC: " + FechaNacim;
            msg += "\n###########################";
            return msg;
        }

    }
}
