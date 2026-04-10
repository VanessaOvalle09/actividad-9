Console.WriteLine("Usted tiene beca?");
string beca = Console.ReadLine();
Console.WriteLine("Cual es su promedio? ");
int promedio = int.Parse(Console.ReadLine());

if (beca == "Si")
{
    Console.WriteLine("Usted tiene baca.");
}
if (promedio >= 35)
{
    Console.WriteLine("Su promedio es igual o mayor a 35.");
}

