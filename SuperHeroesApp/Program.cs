//Poderes
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

var flash = new SuperHeroe();

flash.Id = 2;
flash.Nombre = "The Flash";
flash.IdentidadSecreta = "Barry Allen";
flash.Ciudad = "Central City";
flash.PuedeVolar = false;
flash.SuperPoderes = poderesFlash;

//Usar metodos 
superman.UsarSuperPoderes();
flash.UsarSuperPoderes();

class SuperHeroe 
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
    public void UsarSuperPoderes()
    {
        foreach (var poder in SuperPoderes)
        {
            Console.WriteLine($"{Nombre} puede usar el super poder {poder.Nombre}");
        }
    }
}
class SuperPoder 
{
    public string Nombre = "";
    public string Descripcion = "";
    public NivelPoder Nivel = NivelPoder.NivelUno;
}
enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}