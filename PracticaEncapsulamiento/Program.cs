using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una instancia de contacto
            Contacto contactoUno = new Contacto();

            contactoUno.Nombre = "Nombre";
            contactoUno.Direccion = "Direccion";
            contactoUno.CorreoElectronico = "Correo";
            contactoUno.TelefonoCasa = "Telefono Casa";
            contactoUno.TelefonoCelular = "2339195";

            Console.WriteLine("Nombre: " + contactoUno.Nombre);
            Console.WriteLine("Direccion: " + contactoUno.Direccion);
            Console.WriteLine("Correo Electronico: " + contactoUno.CorreoElectronico);
            Console.WriteLine("Telefon Casa: " + contactoUno.TelefonoCasa);
            Console.WriteLine("Telefono Celular: " + contactoUno.TelefonoCelular);

            Console.ReadLine();
        }
    }
}
