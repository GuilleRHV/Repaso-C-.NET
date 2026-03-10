// See https://aka.ms/new-console-template for more information

Console.WriteLine("Introduce tu nombre: ");
string nombre = Console.ReadLine();
var longitud = 0;
string mayusc = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
for (int i = 1; i <= nombre.Length; i++)
{
    longitud = i;
}
Console.WriteLine("El nombre " + nombre + " tiene una longitud de " + longitud + " caracteres.");
if (char.IsUpper(nombre[0]))
{
    Console.WriteLine("El nombre " + nombre + " empieza por mayuscula");
} else
{
    Console.WriteLine("El nombre " + nombre + " empieza por minuscula");
}
if (char.IsLower(nombre[nombre.Length - 1]))
{
    Console.WriteLine("El nombre " + nombre + " termina en minuscula");
}
if (nombre.Contains("i"))
{
    Console.WriteLine("Contiene la letra i");
}

Console.WriteLine("Introduce un segundo nombre:");
string nombre2 = Console.ReadLine();
string nomComp = nombre + nombre2;
Console.WriteLine(nomComp);
Console.WriteLine("El nombre completo tiene " + nomComp.Length + " caracteres");
Console.WriteLine(nomComp.ToUpper());

//Ejemplo 1
/*Console.WriteLine("Introduce el primer nombre:");
string nombre1 = Console.ReadLine();
Console.WriteLine("Introduce el segundo nombre:");
string nombre2 = Console.ReadLine();
Boolean iguales = false;
if (nombre1 != null && nombre2 != null && nombre1 == nombre2)
{
    iguales = true;
    Console.WriteLine("Los nombre son iguales");
} else
{
    Console.WriteLine("Los nombre son diferentes");
}*/

//Ejemplo2
/*Console.WriteLine("Introduce tu nombre:");
var nombre = Console.ReadLine();
Console.WriteLine("Introduce tu edad:");
var edad = int.Parse(Console.ReadLine());
Console.WriteLine("Se llama " + nombre + " y tiene " + edad + " años");
if (edad >= 18)
{
    Console.WriteLine("Tambien es mayor de edad");
}*/

//Ejemplo3
/*Console.WriteLine("INtroduce un numero:");
var num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce otro:");
var num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("El primer numero es mayor");
} else if (num1 < num2)
{
    Console.WriteLine("El segundo numero es mayor");
} else
{
    Console.WriteLine("Los numeros son iguales");
}*/

//Ejemplo4
/*Console.WriteLine("Introduce un nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("¿Cuantas veces lo quieres repetir?");
var num = int.Parse(Console.ReadLine());
for (int i = 0; i < num; i++)
{
    Console.WriteLine(nombre);
}*/

