int ancho, alto,cantidad;
bool relleno;
Console.WriteLine("Escriba valor para el ancho: ");
ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba valor para el alto: ");
alto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba valor para el relleno: "); ;
relleno = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Escriba cuantas veces quiere que se dibuje la figura: "); ;
cantidad = Convert.ToInt32(Console.ReadLine());
for (int c=1;c<= cantidad;c++)
{
    for (int i = 1; i <= ancho; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    if (relleno == true)
    {
        for (int f = 1; f <= alto - 2; f++)
        {
            for (int i = 1; i <= ancho; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else
    {
        for (int f = 1; f <= alto - 2; f++)
        {
            Console.WriteLine("**");
        }

    }
    for (int i = 1; i <= ancho; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine("\n\n") ;
}
