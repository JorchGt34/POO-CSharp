//Poderes
using System.Text;
using SuperHeroesApp.Models;

var poderVolar = new SuperPoder();

poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire a alta velocidad";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();

superFuerza.Nombre = "Super fuerza";
superFuerza.Descripcion = "Capacidad para levantar objetos pesados y realizar proezas físicas sobrehumanas";
superFuerza.Nivel = NivelPoder.NivelTres;

var superVelocidad = new SuperPoder();

superVelocidad.Nombre = "Super velocidad";
superVelocidad.Descripcion = "Capacidad para moverse a velocidades extremadamente altas";
superVelocidad.Nivel = NivelPoder.NivelTres;

//Lista de superpoderes
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);

List<SuperPoder> poderesFlash = new List<SuperPoder>();
poderesFlash.Add(superFuerza);
poderesFlash.Add(superVelocidad);

//Super heroes
var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
superman.SuperPoderes = poderesSuperman;

/* 
var superman2 = new SuperHeroe();

superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropolis";
superman2.PuedeVolar = true;

Console.WriteLine(superman == superman2); //Compara si los objetos son iguales, pero los objetos de las clases no son iguales aunque tengan los mismos valores

//Records
SuperHeroeRecord superHeroeRecord = new (1, "Superman", "Clark Kent");
SuperHeroeRecord superHeroeRecord2 = new (1, "Superman", "Clark Kent");

Console.WriteLine(superHeroeRecord == superHeroeRecord2); //Compara si los objetos Record son iguales, y como valen lo mismo por sus valores, esto retorna true.
*/

var flash = new SuperHeroe();

flash.Id = 2;
flash.Nombre = "The Flash";
flash.IdentidadSecreta = "Barry Allen";
flash.Ciudad = "Central City";
flash.PuedeVolar = false;
flash.SuperPoderes = poderesFlash;

//Usar metodos 
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
resultSuperPoderes = flash.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

/* 
public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);
*/