using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superheroe)
        {
            Console.WriteLine($"Id: {superheroe.Id}");
            Console.WriteLine($"Nombre: {superheroe.Nombre}");
            Console.WriteLine($"Identidad secreta: {superheroe.IdentidadSecreta}");
        }
    }
}