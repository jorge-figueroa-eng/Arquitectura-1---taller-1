namespace NotificacionesConsola;

/// <summary>
/// Presentación de notificaciones en escritorio  - Concrete implmentation
/// </summary>
public class PlataformaEscritorio : IPlataformaNotificacion
{
    public void MostrarMensaje(string contenido)
    {
        Console.WriteLine($"[ESCRITORIO - Mensaje] {contenido}");
    }

    public void MostrarAlerta(string contenido)
    {
        Console.WriteLine($"[ESCRITORIO - ALERTA] {contenido}");
    }

    public void MostrarAdvertencia(string contenido)
    {
        Console.WriteLine($"[ESCRITORIO - Advertencia] {contenido}");
    }

    public void MostrarConfirmacion(string contenido)
    {
        Console.WriteLine($"[ESCRITORIO - Confirmación]  {contenido}");
    }
}
