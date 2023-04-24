// See https://aka.ms/new-console-template for more information
int p = 0;
int n = 0;
do
{
    Console.WriteLine("Ingrese un numero entero:");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
    {
        Console.WriteLine($"el {x} es positivo");
        p++;
    }
    else if (x < 0)
    {
        Console.WriteLine($"el {x} es negativo");
        n++;
    }
    else { Console.WriteLine("el 0 es neutro"); }
    Console.WriteLine($"Positivos: {p}  Negativos: {n} ");
    Console.WriteLine("quiere continuar ? y/n:");


} while (Console.ReadLine() == "y");
