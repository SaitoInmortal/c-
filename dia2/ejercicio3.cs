// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero:");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("el numero es mayor o igual a 18 es: "+ (n>=18));
Console.WriteLine("Ingrese una letra:");
char l = Convert.ToChar(Console.ReadLine());
bool ia = (l == 'a');
Console.WriteLine("char es igual a ‘a’ es: " + ia);
bool dv = (true && true);
Console.WriteLine("el resuldado de verdadero y verdadero es: " + dv);
bool dd = (true || true);
Console.WriteLine("el resuldado de verdadero o falso es: " + dd);
