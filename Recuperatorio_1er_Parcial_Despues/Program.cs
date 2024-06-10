using Recuperatorio_1er_Parcial_Despues;

class Program
{
    static void Main(string[] args)
    {

        
        List<ICajero> cajeros = new List<ICajero>();


        Cajero cajero = new Cajero();
        cajero.DNI(17740133);
        cajero.Nombre("Roberto");
        cajero.Sueldo(500000);
        cajeros.Add(cajero);


        List<IRepositor> repositores = new List<IRepositor>();


        Repositor repositor = new Repositor();
        repositor.DNI(21590786);
        repositor.Nombre("Diego");
        repositor.Sueldo(400000);
        repositores.Add(repositor);


        List<IFletero> fleteros = new List<IFletero>();

        Fletero fletero = new Fletero();
        fletero.DNI(3);
        fletero.Nombre("Sergio");
        fletero.Sueldo(450000);
        fleteros.Add(fletero);



        foreach (ICajero cajero1 in cajeros)
        {
            
                cajero.Cobrar();
            
        }
        foreach (IFletero fletero1 in fleteros)
        {
                fletero.Entregar();
        }

        foreach (IRepositor repositor1 in repositores)
        {
                repositor.Reponer();
        }
    
        Console.WriteLine("Día de Paga");

    }
}