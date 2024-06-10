using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio_1er_Parcial_Despues
{
    public class Cajero : ICajero, IEmpleado
    {
        private int dni;
        private string nombre;
        private int sueldo;
        private int value;

        public int GetDNI()
        {
            return dni;
        }

        public void DNI(int value)
        {
            dni = value;
        }


        public string GetNombre()
        {
            return nombre;
        }

        public void Nombre(string value)
        {
            nombre = value;
        }


        public int GetSueldo()
        {
            return sueldo;
        }

        public void Sueldo(int value)
        {
            sueldo = value;
        }

        public void Cobrar()
        {
            Console.WriteLine("Cobrando");
        }

        public void CobrarSueldo()
        {
        }
    }
}
