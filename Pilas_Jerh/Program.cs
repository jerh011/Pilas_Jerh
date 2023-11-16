using Pilas_Jerh;

Pila pila = new Pila();
/* if (pila.PilaVacia())
 {
     Console.WriteLine("No hay nada pa' ");
 }
 else
 {
     Console.WriteLine("Si hay algo");
 }*/
if (!pila.PilaLlena())
{
    Console.WriteLine("Aun faltan espacios");
}
else
{
    Console.WriteLine("Esta llena");
}
Console.WriteLine($"La longitud de la pila es {pila.LongitudPila()}");
Console.WriteLine($"La cantidad de elementos real es {pila.CantidadElemento()}");
if (pila.ElementoCima() != -1)
{
    Console.WriteLine($"El valor del elemento cima es {pila.ElementoCima()}");
}
else
{
    Console.WriteLine("La pila no contiene elementos");
}
Console.WriteLine("Ingresar el valor");
int valor = Convert.ToInt32(Console.ReadLine());
if (pila.Push(valor))
{
    Console.WriteLine("El valor se inserto correctamente");
}
else
{
    Console.WriteLine("La pila se encuentra llena");
}
Console.WriteLine("---------------");
pila.ImprimirPila();
Console.WriteLine("---------------");
//Console.WriteLine(pila.ExtraerElemento());
int valor1 = pila.ExtraerElemento();
if (valor1 != -1)
{
    Console.WriteLine($"El elemento extraido fue {valor1}");
}
else
{
    Console.WriteLine("La pila esta vacia");
}

