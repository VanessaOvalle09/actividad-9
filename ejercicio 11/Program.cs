Console.WriteLine("Ingrese su salario: ");
double salario= double.Parse(Console.ReadLine());

double descuento = salario * 0.5;
double descuentomenos = salario - descuento;

Console.WriteLine("Su salario con el descuento del 5% es de: " + descuentomenos);

