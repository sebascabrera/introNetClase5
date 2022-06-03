
Console.Clear();   
string respuesta = "S";

while(respuesta.ToUpper() == "S")
    {
    Console.Write("Ingrese su nombre: ");
    string nombre = (Console.ReadLine());

    Console.Write($"¡Hola {nombre}! \n");


    Console.WriteLine("Desea continuar? S/N");
    respuesta = (Console.ReadLine());
    
}

if (respuesta.ToUpper() == "N")
{
    Console.Write("Programa finalizado correctamente");
}
else
{
    Console.Write("Opcion no valida");
}


