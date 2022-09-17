Cliente cliente = new Cliente("Fernando",432432,"Argentina","email@gmail.com", true);
Console.WriteLine(cliente);
public struct Cliente
{
    public Cliente(string nombre, int tel, string dir, string email, bool nuevo)
    {
        NOM = nombre;
        TEL = tel;
        DIR = dir;
        EMAIL = email;
        NUEVO = nuevo;
    }
    public string NOM { get; }
    public int TEL { get; }
    public string DIR { get; }
    public string EMAIL { get; }
    public bool NUEVO { get; }

    public override string ToString() => $"(Nombre: {NOM}, Telefono: {TEL}, Direccion: {DIR}, Email: {EMAIL}, Nuevo: {NUEVO})";
}