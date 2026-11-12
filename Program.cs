//==============================================
// SISTEMA DE INVENTARIO - Clase 1
// Mensaje de bienvenida
//==============================================

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("┌───────────────────────────────────────────────┐");
Console.WriteLine("│                                               │");
Console.WriteLine("│         BIENVENIDO AL SISTEMA DE INVENTARIO   │");
Console.WriteLine("│                                               │");
Console.WriteLine("└───────────────────────────────────────────────┘");
Console.WriteLine();
Console.WriteLine($"Version: {version}");
Console.WriteLine($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($"Usuario: {Environment.UserName}");
Console.WriteLine($".Net version: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estructura del proyecto...");
Console.WriteLine("├── Program.cs");
Console.WriteLine("├── Models");
Console.WriteLine("│   └── Producto.cs");
Console.WriteLine("└── Views");
Console.WriteLine("    └── InventarioView.cs");