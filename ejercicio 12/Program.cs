Console.WriteLine("Ingrese un numero: ");
double numero = double .Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero: ");
double numero2 = double .Parse(Console.ReadLine());

if (numero > numero2)
{
    Console.WriteLine("El numero mayor es: " + numero);
}
else
{
    Console.WriteLine("El numero mayor es: " + numero2);
}
