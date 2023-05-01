// See https://aka.ms/new-console-template for more information
float p = 20f;
Console.WriteLine("Ingrese su nombre:");
string n = Console.ReadLine();
Console.WriteLine("Ingrese su correo:");
string e = Console.ReadLine();
Console.WriteLine("Tiene un cupon?:");
string d = Console.ReadLine();
d = d.ToUpper();
if (d == "SI" || d == "Y")
{
    float r = p - 5f;
    Console.WriteLine("Total a pagar es: "+ r);
}else
{
    Console.WriteLine("Total a pagar es: " + p);
}
