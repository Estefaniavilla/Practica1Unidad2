int Num1;
string linea;
long RESUL;
Console.WriteLine("Porfavor ingrese un numero: ");
linea = Console.ReadLine(); 
Num1 = int.Parse(linea);
RESUL = Math.Abs(Num1);
Console.WriteLine("Su valor absoluto es: " + RESUL);
Console.WriteLine("Su potencia es: " + Math.Pow(Num1, 3));
Console.WriteLine("Su raiz cuadrada es: " + Math.Sqrt(Num1));
Console.WriteLine("Seno: " + Math.Sin(Num1 * Math.PI / 180));
Console.WriteLine("Coseno: " + Math.Cos(Num1 * Math.PI / 180));
Console.WriteLine("El numero maximo es: " + Math.Max(Num1, 60));
Console.WriteLine("El numero minimo es: " + Math.Min(Num1, 60));
Console.WriteLine("La parte entera es: " + Math.Truncate(23.87));
Console.WriteLine("El redondeo es: " + Math.Round(23.87));
Console.WriteLine("Pulse cualquier tecla: ");
Console.ReadLine();

