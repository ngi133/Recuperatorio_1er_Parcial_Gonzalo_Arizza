using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio_1er_Parcial_Antes
{
    public class Cajero : IEmpleado
    {
        public int DNI;
        public string Nombre;
        public int Sueldo;

  
        public void Cobrar()
        {
            Console.WriteLine("Cobrando");
        }

        public void Entregar()
        {
        }

        public void Reponer()
        {
        }
    }
}
