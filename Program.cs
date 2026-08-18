Console.WriteLine("==Kiosko el recreo==");
string nombreCajero = "Ana";
Console.WriteLine("Nombre del cajero: " + nombreCajero);
Console.WriteLine($"bienvenida, {nombreCajero}. Caja abierta ");

decimal totalVenta = 0;
int cantidadProductos = 0;
string opt;

do
{
    Console.WriteLine("que desea hacer?");
    Console.WriteLine("1. cargar producto");
    Console.WriteLine("2. finalizar venta");
    Console.Write("opcion: ");
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            Console.Write("ingrese producto: ");
            string nombreProducto = Console.ReadLine();
            Console.Write("ingrese precio: ");
            decimal precioProducto = Convert.ToDecimal(Console.ReadLine());
            totalVenta += precioProducto;
            cantidadProductos++;
            break;

        case "2":
            Console.WriteLine("cerrando venta");
            break;

        default:
            Console.WriteLine("opcion invalida");
            break;
    }

} while (opt != "2");
Console.WriteLine($"\ncantidad de productos: {cantidadProductos}");
Console.WriteLine($"total de la venta: ${totalVenta}");

Console.ReadLine();