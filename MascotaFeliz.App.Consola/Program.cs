using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {

        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        //private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        //private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Saludos amigos vamos a trabajar en las tablas :D");
                       
            //ListarDuenosFiltro();      
            //AddDueno();
            //BuscarDueno(2);

            //ListarVeterinariosFiltro();
            //AddVeterinario();
            //BuscarVeterinario(1);

            //AddMascota();

            //BuscarMascota(3);

            //listarMascotas();
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre+ "    "+mascota.Raza+ "   "+mascota.Especie+"    "+mascota.Color);

    
        }

        private static void listarMascotas()
        {
        
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota e in mascotas)
            {
                Console.WriteLine(e.Nombre+ "    "+e.Raza+ "   "+e.Especie+"    "+e.Color);
            
            }
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Maria",
                Apellidos = "López Ortiz", 
                Direccion = "Cr 12 cll 7-37 San Sebastian",
                Telefono = "3017651156",
                Correo = "maria2011@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Sergio Luis",
                Apellidos = "López Ortiz", 
                Direccion = "San Sebastian Magdalena",
                Telefono = "3234177784",
                TarjetaProfesional = "1192727868"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Kira",
                Especie = "Canino", 
                Raza = "Chata",
                Color = "Negro",
            };
            _repoMascota.AddMascota(mascota);
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void ListarDuenosFiltro()
        {
            var duenosM = _repoDueno.GetDuenosPorFiltro("Fel");
            foreach (Dueno p in duenosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }
        private static void ListarVeterinariosFiltro()
        {
            var veterinariosM = _repoVeterinario.GetVeterinariosPorFiltro("e");
            foreach (Veterinario p in veterinariosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }
        }  
    }
}
