Console.WriteLine("Ingrese su cantidad en quetzales: ");
double quetzales= double.Parse(Console.ReadLine());

double iva = quetzales * 0.12;
double ivamenos= quetzales - iva;

Console.WriteLine("El resultado " + ivamenos);
