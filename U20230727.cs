using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú: ");
                Console.WriteLine("1. Asignacion de salarios a empleados");
                Console.WriteLine("2. Listado de dias de la semana");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione una opcion.");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            AsignarSalarios();
                            break;
                        case 2:
                            MostrarDiasSemana();
                            break;
                        case 0:
                            Console.WriteLine("\nSaliendo del programa!!!!!!!!! vuelva pronto");
                            break;
                        default:
                            Console.WriteLine("Opcion no valida, intente nuevamente");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Ingrese un numero valido");
                }
            } while (opcion != 0);

        }
        static void AsignarSalarios()
        {
            List<string?> nombres = new List<string?>();
            List<double> salarios = new List<double>();

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"\nIngrese el nombre del empleado {i}: ");
                string? nombre = Convert.ToString(Console.ReadLine());
                nombres.Add(nombre);

                Console.WriteLine($"Ingrese el salario para {nombre}: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                salarios.Add(salario);
            }

            Console.WriteLine("\nAsignacion de salarios completa... \nDetalles: ");

            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine($"{nombres[i]}: ${salarios[i]}");
            }
        }

        enum DiaSemana
        {
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado,
            Domingo
        }

        static void MostrarDiasSemana()
        {
            foreach (DiaSemana dia in Enum.GetValues(typeof(DiaSemana)))
            {
                if (dia == DiaSemana.Domingo)
                {
                    Console.WriteLine($"\n{dia}: ¡Dia de descanso!");
                }
                else
                {
                    Console.WriteLine($"\n{dia}: Dia de trabajo");
                }
            }
        }
    }
}
