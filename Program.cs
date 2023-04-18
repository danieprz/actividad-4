// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido a este programa para saber que si número es mayor o menor y si el segundo es impar o impar" );
Console.WriteLine("Introduce un número"); 
var primernúmero = Console.ReadLine();
int num1 = int.Parse(primernúmero);
Console.WriteLine("Introduce otro número"); 
var segundonúmero = Console.ReadLine();
int num2 = int.Parse(segundonúmero);
if (num1 > num2)
{
    Console.WriteLine("El " + num1 + " es mayor al " + num2);
}
else if (num1 < num2)
{
    Console.WriteLine("El " + num1 + " es menor al " + num2);
}
else
{
    Console.WriteLine("El " + num1 + " es igual " + num2);
}
if (num2 % 2 == 1)
{
    Console.WriteLine("El " + num2 + " es impar");
}
else
{
    Console.WriteLine("El " + num2 + " es par");
}

