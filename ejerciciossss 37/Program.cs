Console.WriteLine("Ingrese si usted entrego la tarea (Si/No): ");
string tarea=Console.ReadLine();
Console.WriteLine("Cual es su nota? ");
int nota=int.Parse(Console.ReadLine());

if (tarea == "Si")
{
    Console.WriteLine("Excelente!");
}
else
{
    Console.WriteLine("Haga su tarea, huevon.");
}

if (nota > 60)
{
    Console.WriteLine("Excelente!");
}
else
{
    Console.WriteLine("Trate de mejorar.");
}
