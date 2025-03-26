using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp.Models
{
    internal class SuperHeroe : Heroe, ISuperHeroe
    {
        //Propiedades

        private string _Nombre;
        public int Id { get; set; } = 1;
        public override string Nombre 
        { 
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();
            }
        }
        public string NombreEIdentidadSecreta
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }
        public string IdentidadSecreta { get; set; }
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        //Constructor
        public SuperHeroe()
        {
            Id = 0;
            _Nombre = "";
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
                sb.AppendLine($"{NombreEIdentidadSecreta} puede usar el super poder {poder.Nombre}");
            }
            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }
    }
}