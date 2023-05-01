// See https://aka.ms/new-console-template for more information
List<string> lp = new List<string> { "C#", "Java", "C++" };
int id = 1;
foreach (string s in lp)
{
    Console.WriteLine(id+": "+s);
    id++;
}
Console.WriteLine("ingrese el numero del lenguaje a ejecutar:");
int r = Convert.ToInt32(Console.ReadLine());
switch (r){
    case 1:
        Console.WriteLine("resultado: "+ lp[0]);
        Console.WriteLine("hola mundo");
        break;
    case 2:
        Console.WriteLine("resultado: " + lp[1]);
        break;
    case 3:
        Console.WriteLine("resultado: " + lp[2]);
        break;
    default: 
        Console.WriteLine("no encontrado");
        break;

}
