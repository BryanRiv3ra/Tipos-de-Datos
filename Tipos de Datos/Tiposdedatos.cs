Console.WriteLine("Ingrese el primer número entero:");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número entero:");
int numero2 = int.Parse(Console.ReadLine());
int suma = numero1 + numero2;
Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");

Console.WriteLine("Ingrese el numero decimal:");
Decimal decimal1 = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero decimal:");
Decimal decimal2 = Decimal.Parse(Console.ReadLine());
float restaD = numero1 - numero2;
Console.WriteLine($"La resta de {decimal1} y {decimal2} es: {restaD}");

Console.WriteLine("Ingrese el primer número:");
float float1 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
float float2 = float.Parse(Console.ReadLine());
float multi = float1 * float2;
Console.WriteLine($"La multiplicacion de {float1} y {float2} es: {multi}");


