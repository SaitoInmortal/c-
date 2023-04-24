// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero entero para generar la tabla:");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= 10)
{
    Console.WriteLine($"{x} x {i} = {x*i}");
    i++;
}
