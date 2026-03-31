using System;

namespace AnimeCrudPro
{
    class Program
    {
        // Instanciamos el repositorio que ya tiene tus 4 métodos SQL
        static AnimeRepository repo = new AnimeRepository();

        static void Main()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=====================================");
                Console.WriteLine("    ⛩️  SISTEMA DE GESTIÓN ANIME  ⛩️    ");
                Console.WriteLine("=====================================");
                Console.ResetColor();
                Console.WriteLine("1. Agregar Anime");
                Console.WriteLine("2. Ver Catálogo");
                Console.WriteLine("3. Editar Anime");
                Console.WriteLine("4. Eliminar Anime");
                Console.WriteLine("5. Salir");
                Console.Write("\nSelecciona una opción: ");

                string opcion = Console.ReadLine() ?? "";

                try
                {
                    switch (opcion)
                    {
                        case "1": Agregar(); break;
                        case "2": Listar(); break;
                        case "3": Editar(); break;
                        case "4": Eliminar(); break;
                        case "5": continuar = false; break;
                        default: Console.WriteLine("Opción no válida."); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n⚠️ Error: {ex.Message}");
                    Console.ResetColor();
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }

        static void Agregar()
        {
            Console.Write("\nTítulo del Anime: ");
            string t = Console.ReadLine() ?? "";
            Console.Write("Cantidad de Episodios: ");
            int e = int.Parse(Console.ReadLine() ?? "0");
            
            repo.Crear(new Anime { Titulo = t, Episodios = e });
            Console.WriteLine("\n✅ ¡Guardado en la base de datos!");
        }

        static void Listar()
        {
            var lista = repo.ObtenerTodos();
            Console.WriteLine("\n--- CATÁLOGO ACTUAL ---");
            if (lista.Count == 0) Console.WriteLine("No hay registros en SQL.");
            foreach (var a in lista)
                Console.WriteLine($"ID: {a.Id} | {a.Titulo} ({a.Episodios} eps)");
        }

        static void Editar()
        {
            Console.Write("\nID del anime a editar: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nuevo Título: ");
            string t = Console.ReadLine() ?? "";
            Console.Write("Nuevos Episodios: ");
            int e = int.Parse(Console.ReadLine() ?? "0");
            
            if (repo.Actualizar(new Anime { Id = id, Titulo = t, Episodios = e }))
                Console.WriteLine("\n✅ Actualización exitosa.");
            else
                Console.WriteLine("\n❌ ID no encontrado.");
        }

        static void Eliminar()
        {
            Console.Write("\nID del anime a eliminar: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            
            if (repo.Eliminar(id))
                Console.WriteLine("\n🗑️ Eliminado de SQL Server.");
            else
                Console.WriteLine("\n❌ ID no encontrado.");
        }
    }
}