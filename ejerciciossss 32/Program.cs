Console.WriteLine("Tiene DPI? (Si/No)");
string dpi=Console.ReadLine();
Console.WriteLine("Es mayor de 18?");
int edad=int.Parse(Console.ReadLine());

if (dpi == "Si" && edad >= 18 )
{
    Console.WriteLine("Si, usted puede votar.");
}
