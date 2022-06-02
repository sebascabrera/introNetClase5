
    string respuesta = "S";

while(respuesta.ToUpper() != "N")
    {
    Console.Write("Ingrese su nombre: ");
    string nombre = (Console.ReadLine());

    Console.Write($"Hola {nombre} \n");


    Console.WriteLine("Desea continuar? S/N");
    respuesta = (Console.ReadLine());
    
}
