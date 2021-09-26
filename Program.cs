using ENTIDAD;
using SEVICIOS;
using System;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {


            Menu();

        }
        private static void Menu()
        {
            RegistroAceiteServicio servicio = new RegistroAceiteServicio();
            Console.Clear();
            int opcion;
            do
            {
                Console.WriteLine("\t\t\t _________________________________");
                Console.WriteLine("\t\t\t|        MENU PRINCIPAL          |");
                Console.WriteLine("\t\t\t|________________________________|");
                Console.WriteLine("\t\t\t|  1 guardar cambios de aceites  |");
                Console.WriteLine("\t\t\t|  2 Listado de cambios de aceite|");
                Console.WriteLine("\t\t\t|  3 salir                       |");
                Console.WriteLine("\t\t\t|________________________________|");
                Console.WriteLine("\t\t\t                                  ");
                Console.WriteLine("Escoja una opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Guardar();
                        break;
                    case 2: ConsultaGeneral(servicio);
                        break;
                    case 3: Console.SetCursorPosition(25, 15);
                        Console.WriteLine("Gracias por usar el sistema");
                        break;
                    default:Console.WriteLine("Funcion invalida");
                        Console.ReadKey();
                           
                        break;


                }
            }


            while (opcion != 3);


          
      


        }
       
        private static void ConsultaGeneral(RegistroAceiteServicio service)
        {
            Console.Clear();
            RespuestaConsulta respuestaConsulta = service.consultar();
            Console.WriteLine(respuestaConsulta.Mensaje);
            if (!respuestaConsulta.Error)
            {

                foreach (var item in respuestaConsulta.registros)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        private static void Guardar()
        {
            Console.Clear();

            RegistroAceite registro = new RegistroAceite();
            Console.WriteLine("Digite la identificacion");
            registro.IdPropietario = Console.ReadLine();
            Console.WriteLine("Digite Nombres");
            registro.NombresPropietario = Console.ReadLine();
            Console.WriteLine("Digite los apellidos");
            registro.ApellidoPropietario = Console.ReadLine();
            Console.WriteLine("Digite la placa");
            registro.PlacaVehiculo = Console.ReadLine();
            Console.WriteLine("Digite la marca del vehiculo");
            registro.Marca = Console.ReadLine();
            Console.WriteLine("Digite el tipo de aceite");
            registro.TipoAceite = Console.ReadLine();
            Console.WriteLine("Digite la fecha de cambio");
            registro.FechaCambio = Console.ReadLine();
            RegistroAceiteServicio servicio = new RegistroAceiteServicio();
            string mensaje = servicio.Guardar(registro);
            Console.WriteLine(mensaje);
            Console.ReadKey();






        }

    }
}
