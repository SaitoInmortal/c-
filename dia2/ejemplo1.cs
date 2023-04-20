// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese su nombre:");
string n  = Console.ReadLine();
Console.WriteLine("Ingrese su apellido:");
string a = Console.ReadLine();
Console.WriteLine("Ingrese su edad:");
int edad = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Ingrese y si sabe programar y una n si no:");
bool sp;
if (Console.ReadLine() == "y"){
    sp = true;
}else{ 
    sp = false;
}
Console.WriteLine("------------------------------------------");
Console.WriteLine("Hola "+n+" "+a);
Console.WriteLine("Asi que tienes "+ edad+" años");
if (sp) { 
    Console.WriteLine("Buena edad para saber progamar"); 
} else { 
    Console.WriteLine("Que mal que no sepas progamar"); 
}
