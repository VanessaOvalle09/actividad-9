Console.WriteLine("Ingrese su horas trabajadas: ");
double horas=double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su pago por hora: ");
double pago=double.Parse(Console.ReadLine());

double multiplicacion = horas * pago;
Console.WriteLine("Su salario es de: " + multiplicacion);
