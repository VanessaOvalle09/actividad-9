using System.Xml;

Console.WriteLine("Ingrese un numero: ");
int numero=int.Parse(Console.ReadLine());

if (numero >= 0 && numero <= 100)
{
    Console.WriteLine("Su numero esta en el rango de 0 a 100");
}
else
{
    Console.WriteLine("Su numero no esta en el rango");
}
