Console.WriteLine("Opcion a: C#\nOpcion b: Java\nOpcion c: C++");
char opc = Convert.ToChar(Console.ReadLine());
switch (opc)
{
    case 'a': Console.WriteLine("Hola, mundo C#");
        break;
    case 'b': Console.WriteLine("Java");
        break ;
    case 'c': Console.WriteLine("C++");
        break;
    default: Console.WriteLine("Ninguno fue seleccionado");
        break;
}