//Una clase es un molde para crear objetos
ControlXboxElite controlJorge = new ControlXboxElite();
ControlXboxElite controlNatalia = new ControlXboxElite();

controlJorge.Color = "Negro";
controlNatalia.Color = "Azul";
class ControlXboxElite
{
    public string Color;
    public double Largo;
    public short NumeroDeBotones;
    public bool TieneAccesoriosPuestos;
}