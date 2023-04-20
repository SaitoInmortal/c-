// See https://aka.ms/new-console-template for more information
Coche c = new Coche();
Mesa m = new Mesa();
Console.WriteLine("Ingrese las puertas de su coche:");
c.Puertas = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingrese las ruedas de su coche:");
c.Ruedas = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ingrese la marca de su coche:");
c.Marca = Console.ReadLine();
Console.WriteLine("La ITV de su coche esta vigente y/n:");
if (Console.ReadLine() == "y")
{
    c.ITVvigente = true;
}
else
{
    c.ITVvigente = false;
}
Console.WriteLine(c);
Console.WriteLine("Ingrese el peso de la mesa:");
m.Peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el largo de la mesa:");
m.largo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el material de la mesa:");
m.Material = Console.ReadLine();
Console.WriteLine("Ingrese el color de la mesa:");
m.Color = Console.ReadLine();
Console.WriteLine(m);
class Coche
{
    public int Puertas { get; set; }
    public int Ruedas { get; set; }
    public string Marca { get; set; }
    public bool ITVvigente { get; set; }

}
class Mesa
{
    public double Peso { get; set; }
    public double largo { get; set; }
    public string Material { get; set; }
    public string Color { get; set; }

}
