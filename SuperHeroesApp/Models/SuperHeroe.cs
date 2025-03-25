using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class SuperHeroe
    {

        //Propiedades
        public int Id;
        public string Nombre;
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        //Constructor
        public SuperHeroe()
        {
            Id = 0;
            Nombre = "";
            IdentidadSecreta = "";
            Ciudad = "";
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        //Metodos
        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var poder in SuperPoderes)
            {
                sb.AppendLine($"{Nombre} puede usar el super poder {poder.Nombre}");
            }
            return sb.ToString();
        }
    }
}