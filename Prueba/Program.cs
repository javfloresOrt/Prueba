using Prueba;

Console.WriteLine("Inicio");

Persona persona = new Persona();

persona.DNI = 1111111111;
persona.Nombre = "Juan";
persona.Apellido = "Perez";

//Console.WriteLine($"DNI: {persona.DNI},Nombre: {persona.Nombre},Apellido: {persona.Apellido}");

Console.WriteLine(persona.MostraDatos());

Console.WriteLine("Final");