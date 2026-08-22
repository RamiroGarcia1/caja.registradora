Console.WriteLine("==Kiosko el recreo==");
string nombreCajero = "Ana";
Console.WriteLine("Nombre del cajero: " + nombreCajero);
Console.WriteLine($"bienvenida, {nombreCajero}. Caja abierta ");

const decimal PorcentajeDescuento10 = 0.10m;
const decimal PorcentajeDescuento5 = 0.05m;
decimal totalVenta = 0;
int cantidadProductos = 0;
string opt;

do
{
    Console.WriteLine("\nque desea hacer?");
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
            Console.WriteLine("Cerrando la venta..");
            break;

        default:
            Console.WriteLine("opcion invalida");
            break;
    }

} while (opt != "2");

decimal porcentajeAplicado = 0m;

if (totalVenta > 50000m)
{
    porcentajeAplicado = PorcentajeDescuento10;
}
else if (totalVenta > 20000m)
{
    porcentajeAplicado = PorcentajeDescuento5;
}

decimal descuento = totalVenta * porcentajeAplicado;
decimal totalFinal = totalVenta - descuento;

Console.WriteLine($"cantidad de productos: {cantidadProductos}");
Console.WriteLine($"subtotal: ${totalVenta}");
Console.WriteLine($"descuento aplicado: ${descuento}");
Console.WriteLine($"total con descuento: ${totalFinal}");

Console.ReadLine();