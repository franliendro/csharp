Console.WriteLine("Escriba un numero entero:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Tabla de multiplicar del {num}");
int i = 1;
while(i <= 10)
{
    Console.WriteLine($"{num}*{i}={num*i}\n");
    i++;
}