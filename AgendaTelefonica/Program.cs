
using AgendaTelefonica;

opciones opcion = opciones.Salir;
var directorio = new Directorio();
directorio.AdicionarContacto(new Contacto() { Nombre = "Juan", Celular = "10", Telefono = "20"});
directorio.ListarContactos();

Console.ReadKey();
//do
//{
//    MostrarMenu();

//    opcion = LeerOpcionseleccionada();
//    EjecutarOpcion(opcion);

//} while (opcion != opciones.Salir);

void EjecutarOpcion(opciones opcion)
{
    if(opcion == opciones.Salir)
    {
        return;
    }

    switch(opcion)
    {
        case opciones.AdicionarContacto:
            AdicionarContactoCommand();
            break;
    }
}

void AdicionarContactoCommand()
{
    throw new NotImplementedException();
}

static opciones LeerOpcionseleccionada()
{
    int opcionNumerica;
    opciones opcionSeleccionada;
    var opcionIngresada = Console.ReadLine();

    if (int.TryParse(opcionIngresada, out opcionNumerica))
    {
        opcionSeleccionada = (opciones)opcionNumerica;
        
        return opcionSeleccionada;
    }

    return opciones.RepetirMenu;
}

static void MostrarMenu()
{
    Console.WriteLine("Seleccione una de las siguientes opciones:");
    Console.WriteLine("Seleccione una de las siguientes opciones:");
    Console.WriteLine("1. AdicionarContacto");
    Console.WriteLine("2. ListarContactos");
    Console.WriteLine("3. BuscarContacto");
    Console.WriteLine("4. ExisteContacto");
    Console.WriteLine("5. EliminarContacto");
    Console.WriteLine("6. AgendaLlena");
    Console.WriteLine("7. Salir");
}
enum opciones
{
    AdicionarContacto = 1,
    ListarContactos,
    BuscarContacto,
    ExisteContacto,
    EliminarContacto,
    AgendaLlena,
    Salir,
    RepetirMenu
};