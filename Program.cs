using System;

namespace XM_OPERACIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            Xml mixml = new Xml();
            mixml._crearXml("Datos.xml", "Empleados");
         
            mixml._Añadir("1", "Jhon", "CUVI", "Universitario");
            mixml._Añadir("2", "SEBAS", "JATIVA", "Universitario");
            mixml._Añadir("3", "SAMY", "GUERRERO", "Universitario");
            mixml._Añadir("4", "MAIK", "SANTILLAN", "Universitario");
            mixml._Añadir("5", "DIEGO", "LOGROÑO", "Universitario");
            mixml._Añadir("6", "ROMERO", "ROMERO", "Universitario");

            Console.WriteLine("\t\t  Parser para extraer información de un documento XML\n");
            Console.WriteLine("\n---------------------------------------------------------------");
            Console.WriteLine("\n\t  LECTURA DE UN XML MEDIANTE PARSERDOM");
            mixml._ReadXml();
            mixml._DeleteNodo("1");

            Console.WriteLine("\n\n\t  ELIMINANDO A ID: 1 y MOFICANDO XML");
            Console.WriteLine("\n---------------------------------------------------------------");

            mixml._ReadXml();

            Console.ReadKey();

        }
    }
}
