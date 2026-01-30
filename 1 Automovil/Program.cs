using AutomovilConsola;

Console.WriteLine("=== Configurador de automóviles Patron de Diseño Builder ===\n");

Automovil automovil;
Director director = new Director(new AutomovilBuilder());


// Ejemplo 1: Automóvil básico (solo lo que queremos, el resto por defecto)
automovil = director.ConstruiBasico();
Console.WriteLine("--- Automóvil básico ---");
Console.WriteLine(automovil);
Console.WriteLine();

// Ejemplo 2: Automóvil deportivo
automovil = director.ConstruirDeportivo();
Console.WriteLine("--- Automóvil deportivo ---");
Console.WriteLine(automovil);
Console.WriteLine();


// Ejemplo 3: Automóvil familiar
automovil = director.ConstruirFamiliar();
Console.WriteLine("--- Automóvil familiar ---");
Console.WriteLine(automovil);
Console.WriteLine();


Console.WriteLine("\nPulse una tecla para salir...");
Console.ReadKey();
