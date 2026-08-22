Console.WriteLine("==Kiosko el recreo==");
string nombreCajero = "Ana";
Console.WriteLine($"Nombre del cajero: {nombreCajero}");
Console.WriteLine($"bienvenida, {nombreCajero}. Caja abierta ");

const decimal PorcentajeDescuento10 = 0.10m;
const decimal PorcentajeDescuento5 = 0.05m;
const decimal DescuentoEfectivo = 0.10m;
const decimal RecargoCredito = 0.15m;

decimal totalVenta = 0;
int cantidadProductos = 0;
string opt;

do
{
    Console.WriteLine($"que desea hacer?");
    Console.WriteLine($"1. cargar producto");
    Console.WriteLine($"2. finalizar venta");
    Console.Write($"ingrese una opcion: ");
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            Console.Write($"ingrese producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write($"ingrese precio: ");
            decimal precioProducto = Convert.ToDecimal(Console.ReadLine());

            totalVenta += precioProducto;
            cantidadProductos++;
            break;

        case "2":
            Console.WriteLine($"Cerrando la venta..");
            break;

        default:
            Console.WriteLine($"opcion invalida");
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

decimal descuentoMonto = totalVenta * porcentajeAplicado;
decimal subtotalConDescuento = totalVenta - descuentoMonto;

string medioPago;
bool opcionValida = false;
decimal descuentoEfectivo = 0m;
decimal recargoCredito = 0m;

do
{
    Console.WriteLine($"Seleccione el medio de pago:");
    Console.WriteLine($"1 - Efectivo (10% de descuento)");
    Console.WriteLine($"2 - Debito (sin descuento)");
    Console.WriteLine($"3 - Credito (15% recargo)");
    Console.Write($"Opcion: ");
    medioPago = Console.ReadLine();

    switch (medioPago)
    {
        case "1":
            descuentoEfectivo = subtotalConDescuento * DescuentoEfectivo;
            opcionValida = true;
            break;

        case "2":
            opcionValida = true;
            break;

        case "3":
            recargoCredito = subtotalConDescuento * RecargoCredito;
            opcionValida = true;
            break;

        default:
            Console.WriteLine("Opcion invalida. Intente nuevamente");
            break;
    }
} while (!opcionValida);

decimal descuentoTotal = descuentoMonto + descuentoEfectivo;
decimal totalFinal = subtotalConDescuento - descuentoEfectivo + recargoCredito;

void ImprimirLinea()
{
    for (int i = 0; i < 30; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
}

Console.WriteLine("\n");
ImprimirLinea();
Console.WriteLine($"       KIOSCO EL RECREO       ");
ImprimirLinea();
Console.WriteLine($"Cajero: {nombreCajero}");
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: {totalVenta}");
Console.WriteLine($"Descuento: {descuentoTotal}");
Console.WriteLine($"Recargo: {recargoCredito}");
ImprimirLinea();
Console.WriteLine($"TOTAL: {totalFinal}");
ImprimirLinea();

Console.ReadLine();