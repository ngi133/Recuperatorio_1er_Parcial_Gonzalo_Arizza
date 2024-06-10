
using Recuperatorio_1er_Parcial_Antes;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {

        List<IEmpleado> empleados = new List<IEmpleado>();

        Cajero cajero = new Cajero();
        cajero.DNI = 17740133;
        cajero.Nombre = "Roberto";
        cajero.Sueldo = 500000;
        empleados.Add(cajero);

        Repositor repositor = new Repositor();
        repositor.DNI = 2;
        repositor.Nombre = "Diego";
        repositor.Sueldo = 400000;
        empleados.Add(repositor);

        Fletero fletero = new Fletero();
        fletero.DNI = 3;
        fletero.Nombre = "Sergio";
        fletero.Sueldo = 450000;
        empleados.Add(fletero);


        foreach (IEmpleado empleado in empleados)
        {
            if (empleado is Cajero)
            {
                empleado.Cobrar();
            }
            if (empleado is Fletero)
            {
                empleado.Entregar();
            }
            else
            {
                empleado.Reponer();
            }
        }
    }
}
