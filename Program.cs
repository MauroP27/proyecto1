using System;
using System.Data.Common;

class Program
{
    static void Main()
    {

        DateTime fecha;
        TimeSpan hora;

    Console.Write("Ingrese el ID del articulo: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Ingrese la descripcion del articulo: ");
    string descripcion = Console.ReadLine();

    DateTime fechahoraActual = DateTime.Now;

    DateTime fechaActual = fechahoraActual.Date;
    TimeSpan horaActual = fechahoraActual.TimeOfDay;

    Console.WriteLine("\n\nID ingresado: " + id);
    Console.WriteLine("Descripcion del articulo: " + descripcion);
    Console.WriteLine("Fecha: " + fechaActual.ToString("dd-mm-yyyy"));
    Console.WriteLine("Hora: " + horaActual.ToString());
    
    }

}
