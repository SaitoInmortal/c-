// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el ancho:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el alto:");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el numero de figuras a dibujar:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("desea rellenar la figura? True/False:");
bool r = Convert.ToBoolean(Console.ReadLine());
int x = 0;
do {
    if (r) {
        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < a; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }else {
        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (i == 0 || i == (l - 1) || j ==0 || j == (a - 1)) {
                    Console.Write("*");
                }else { Console.Write(" "); }
            }
            Console.WriteLine();
        }
    }
    x++;
}while (x!=n);
