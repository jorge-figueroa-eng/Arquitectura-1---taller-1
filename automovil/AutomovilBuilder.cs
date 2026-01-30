namespace AutomovilConsola;


public class AutomovilBuilder
{
    private string _tipoMotor = "Estándar";
    private string _color = "Blanco";
    private string _llantas = "Estándar 16\"";
    private string _sistemaSonido = "Básico";
    private string _interiores = "Tela";
    private bool _techoSolar = false;
    private bool _navegacionGps = false;
    private string? _modelo = null;

    /// <summary>
    /// Configura el tipo de motor.
    /// </summary>
    public AutomovilBuilder ConMotor(string tipoMotor)
    {
        _tipoMotor = tipoMotor;
        return this;
    }

    /// <summary>
    /// Configura el color exterior.
    /// </summary>
    public AutomovilBuilder ConColor(string color)
    {
        _color = color;
        return this;
    }

    /// <summary>
    /// Configura el tipo de llantas.
    /// </summary>
    public AutomovilBuilder ConLlantas(string llantas)
    {
        _llantas = llantas;
        return this;
    }

    /// <summary>
    /// Configura el sistema de sonido.
    /// </summary>
    public AutomovilBuilder ConSistemaSonido(string sistemaSonido)
    {
        _sistemaSonido = sistemaSonido;
        return this;
    }

    /// <summary>
    /// Configura los interiores.
    /// </summary>
    public AutomovilBuilder ConInteriores(string interiores)
    {
        _interiores = interiores;
        return this;
    }

    /// <summary>
    /// Incluye o no techo solar.
    /// </summary>
    public AutomovilBuilder ConTechoSolar(bool incluir = true)
    {
        _techoSolar = incluir;
        return this;
    }

    /// <summary>
    /// Incluye o no navegación GPS.
    /// </summary>
    public AutomovilBuilder ConNavegacionGps(bool incluir = true)
    {
        _navegacionGps = incluir;
        return this;
    }

    /// <summary>
    /// Asigna un nombre o modelo base al automóvil.
    /// </summary>
    public AutomovilBuilder ConModelo(string modelo)
    {
        _modelo = modelo;
        return this;
    }

   
    public Automovil Build()
    {
        return new Automovil(
            _tipoMotor,
            _color,
            _llantas,
            _sistemaSonido,
            _interiores,
            _techoSolar,
            _navegacionGps,
            _modelo);
    }

   public static AutomovilBuilder Crear()
{
    return new AutomovilBuilder();
}
}
