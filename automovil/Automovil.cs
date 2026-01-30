namespace AutomovilConsola;


public class Automovil
{
    public string TipoMotor { get; }
    public string Color { get; }
    public string Llantas { get; }
    public string SistemaSonido { get; }
    public string Interiores { get; }
    public bool TechoSolar { get; }
    public bool NavegacionGps { get; }
    public string? Modelo { get; }

  
    internal Automovil(
        string tipoMotor,
        string color,
        string llantas,
        string sistemaSonido,
        string interiores,
        bool techoSolar,
        bool navegacionGps,
        string? modelo)
    {
        TipoMotor = tipoMotor;
        Color = color;
        Llantas = llantas;
        SistemaSonido = sistemaSonido;
        Interiores = interiores;
        TechoSolar = techoSolar;
        NavegacionGps = navegacionGps;
        Modelo = modelo;
    }

    /// <summary>
    /// Rautomóvil configurado.
    /// </summary>
    public override string ToString()
    {
        var partes = new List<string>
        {
            $"Modelo: {Modelo ?? "Personalizado"}",
            $"Motor: {TipoMotor}",
            $"Color: {Color}",
            $"Llantas: {Llantas}",
            $"Sistema de sonido: {SistemaSonido}",
            $"Interiores: {Interiores}",
            $"Techo solar: {(TechoSolar ? "Sí" : "No")}",
            $"Navegación GPS: {(NavegacionGps ? "Sí" : "No")}"
        };
        return string.Join(Environment.NewLine, partes);
    }
}
