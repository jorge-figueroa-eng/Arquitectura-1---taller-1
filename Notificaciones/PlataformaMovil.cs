namespace NotificacionesConsola;

/// <summary>
/// Presentación de notificaciones en Movil  - Concrete implmentation
/// </summary>
public class PlataformaMovil : IPlataformaNotificacion
{
    public void MostrarMensaje(string contenido)
    {
        Console.WriteLine($"[MÓVIL - Mensaje]  {contenido}");
    }

    public void MostrarAlerta(string contenido)
    {
        Console.WriteLine($"[MÓVIL - ALERTA]  {contenido}");
    }

    public void MostrarAdvertencia(string contenido)
    {
        Console.WriteLine($"[MÓVIL - Advertencia] {contenido}");
    }

    public void MostrarConfirmacion(string contenido)
    {
        Console.WriteLine($"[MÓVIL - Confirmación]  {contenido}");
    }
}
