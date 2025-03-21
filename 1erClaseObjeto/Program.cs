//Una clase es un molde para crear objetos
ControlXboxElite controlJorge = new ControlXboxElite();
ControlXboxElite controlNatalia = new ControlXboxElite();

controlJorge.Color = "Negro";
controlNatalia.Color = "Azul";

SuperHeroe sonic = new SuperHeroe();
sonic.nombre = "Sonic The Hedgehog";
sonic.superPoder = "Super velocidad";
sonic.estaturaCm = 90;
sonic.edad = 15;
sonic.tieneIdentidadSecreta = false;
sonic.usaCapa = false;
Console.WriteLine(sonic.tieneIdentidadSecreta);
class ControlXboxElite
{
    public string Color;
    public double Largo;
    public short NumeroDeBotones;
    public bool TieneAccesoriosPuestos;
}

class SuperHeroe {
    public string nombre;
    public string superPoder;
    public int estaturaCm;
    public int edad;
    public bool tieneIdentidadSecreta;
    public bool usaCapa;
}