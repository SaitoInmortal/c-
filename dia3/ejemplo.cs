Cliente cliente1 = new Cliente(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Convert.ToBoolean(Console.ReadLine()));
Console.WriteLine(cliente1);
class Cliente
{
    public Cliente(string n, string t, string d, string e, bool nc) {
        Nombre = n;
        Telefono = t;
        Direccion = d;
        Email = e;
        NuevoCliente = nc;
    }
    public string Nombre {  get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }

    public bool NuevoCliente { get; set; }
    public override string ToString()
    {
        return $"Cliente: {Environment.NewLine} Nombre: {Nombre} {Environment.NewLine} Telefono: {Telefono} {Environment.NewLine} Direccion: {Direccion} {Environment.NewLine} Email: {Email} {Environment.NewLine} Es nuevo cliente: {NuevoCliente}";
    }
}
