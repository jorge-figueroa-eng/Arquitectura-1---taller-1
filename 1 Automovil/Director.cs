namespace AutomovilConsola;
public class Director
{
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public Automovil ConstruiBasico()
    {
        return _builder
            .ConMotor("Norlmal")
            .ConColor("Rojo")
            .ConLlantas("Normales")
            .Crear();
    }

    public Automovil ConstruirDeportivo()
    {
        return _builder
            .ConMotor("V8")
            .ConColor("Rojo")
            .ConLlantas("Deportivas")
            .ConSistemaSonido("Premium")
            .ConInteriores("Cuero")
            .ConTechoSolar(true)
            .ConNavegacionGps(true)
            .ConModelo("Deportivo X")
            .Crear();
    }

    public Automovil ConstruirFamiliar()
    {
        return _builder
            .ConMotor("V6")
            .ConColor("Azul")
            .ConLlantas("Estándar")
            .ConSistemaSonido("Estándar")
            .ConInteriores("Tela")
            .ConTechoSolar(false)
            .ConNavegacionGps(true)
            .ConModelo("Familiar Y")
            .Crear();
    }
}   