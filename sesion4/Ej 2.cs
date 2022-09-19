int num,contPositivos=0,contNegativos=0;
do
{
    Console.WriteLine("Escribir un numero: ");
    num=Convert.ToInt32(Console.ReadLine());
    if (num > 0) contPositivos++;
    if (num<0) contNegativos++;
}while (num!=0);
Console.WriteLine($"Hubieron {contPositivos} numeros positivos y {contNegativos} numeros negativos");