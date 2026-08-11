Console.WriteLine("==Kiosko el recreo==");

string nombreCajero = "Ana";

Console.WriteLine("Nombre del cajero: " + nombreCajero);
Console.WriteLine($"bienvenida, {nombreCajero}. Caja abierta ");

Console.Write("ingrese producto: ");
string nombreProducto = Console.ReadLine();
Console.Write("ingrese precio: ");
decimal precioProducto = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Producto: {nombreProducto},Precio: {precioProducto}");

