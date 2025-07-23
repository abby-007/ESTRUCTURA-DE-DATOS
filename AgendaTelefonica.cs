using System;

namespace AgendaTelefonica
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Contacto(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}, Teléfono: {Telefono}");
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Contacto[] agenda = new Contacto[100];
            int cantidad = 0;
            int opcion;

            do
            {
                Console.WriteLine("\n--- AGENDA TELEFÓNICA ---");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar todos los contactos");
                Console.WriteLine("3. Buscar contacto por nombre");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (cantidad < agenda.Length)
                        {
                            Console.Write("Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Teléfono: ");
                            string telefono = Console.ReadLine();
                            agenda[cantidad] = new Contacto(nombre, telefono);
                            cantidad++;
                            Console.WriteLine("Contacto agregado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Agenda llena.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- Lista de Contactos ---");
                        for (int i = 0; i < cantidad; i++)
                        {
                            agenda[i].Mostrar();
                        }
                        break;

                    case 3:
                        Console.Write("Ingrese el nombre a buscar: ");
                        string buscar = Console.ReadLine();
                        bool encontrado = false;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (agenda[i].Nombre.Equals(buscar, StringComparison.OrdinalIgnoreCase))
                            {
                                agenda[i].Mostrar();
                                encontrado = true;
                                break;
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("Contacto no encontrado.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
