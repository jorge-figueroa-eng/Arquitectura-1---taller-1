namespace NotificacionesConsola;

/// <summary>
/// Presentación de notificaciones en WEB  - Concrete implmentation

/// </summary>
public class PlataformaWeb : IPlataformaNotificacion
{
    public void MostrarMensaje(string contenido)
    {
        Console.WriteLine($"[WEB - Mensaje] {contenido}");
    }
    

    public void MostrarAlerta(string contenido)
    {
        Console.WriteLine($"[WEB - ALERTA] {contenido}");
    }
    

    public void MostrarAdvertencia(string contenido)
    {
        Console.WriteLine($"[WEB - Advertencia] {contenido}");
    }
    

    public void MostrarConfirmacion(string contenido)
    {
        Console.WriteLine($"[WEB - Confirmación]{contenido}");
    
    }
}
