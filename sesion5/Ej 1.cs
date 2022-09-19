float precio = 45;
Cliente cliente = new Cliente();
Console.WriteLine("Escriba nombre: ");
cliente.NOM = Console.ReadLine();
Console.WriteLine("Escriba email: "); ;
cliente.EMAIL = Console.ReadLine();
Console.WriteLine("Escriba si tiene cupon: ");
cliente.CUPON = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine(cliente);
if (cliente.CUPON == true) Console.WriteLine($"El precio del producto es {precio} pero con el descuento es {precio/2}");
else Console.WriteLine($"El precio del producto es {precio}");
public struct Cliente
{
    public Cliente(string nom, string email,bool cupon)
    {
        
        NOM = nom;
        EMAIL = email;
        CUPON = cupon;
    }

    public string NOM { get; set; }
    public string EMAIL { get; set; }
    public bool CUPON { get; set; }

    public override string ToString() => $"({NOM}, {EMAIL},{CUPON})";
}