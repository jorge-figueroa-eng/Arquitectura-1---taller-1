using AutomovilConsola;

Console.WriteLine("=== Configurador de automóviles ===\n");

// Ejemplo 1: Automóvil básico (solo lo que queremos, el resto por defecto)
var autoBasico = AutomovilBuilder.Crear()
    .ConColor("Negro")
    .ConModelo("Sedan Base")
    .Build();

Console.WriteLine("--- Automóvil básico ---");
Console.WriteLine(autoBasico);
Console.WriteLine();

// Ejemplo 2: Automóvil totalmente personalizado
var autoPremium = AutomovilBuilder.Crear()
    .ConModelo("SUV Premium")
    .ConMotor("V6 Turbo")
    .ConColor("Azul metálico")
    .ConLlantas("Aleación 20\"")
    .ConSistemaSonido("Premium 12 altavoces")
    .ConInteriores("Cuero negro")
    .ConTechoSolar(true)
    .ConNavegacionGps(true)
    .Build();

Console.WriteLine("--- Automóvil premium ---");
Console.WriteLine(autoPremium);
Console.WriteLine();

var autoDeportivo = AutomovilBuilder.Crear()
    .ConModelo("Coupé Deportivo")
    .ConMotor("V8")
    .ConColor("Rojo")
    .ConLlantas("Deportivas 19\"")
    .ConInteriores("Cuero y alcántara")
    .Build(); 

Console.WriteLine("--- Automóvil deportivo ---");
Console.WriteLine(autoDeportivo);

Console.WriteLine("\nPulse una tecla para salir...");
Console.ReadKey();
