using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BiblioMascota;

namespace ConsolaVeterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota m1 = new Mascota();
            m1.Id = 1001;
            m1.Nombre = "KUKI";
            m1.Raza = "SHITZ SU";
            m1.Sexo = "HEMBRA";
            m1.Edad = 4;
            m1.Vacunado = true;
            m1.FechaNacim = new DateTime(2017, 5, 21);

            m1.ImprimirFicha();
        }
    }
}
