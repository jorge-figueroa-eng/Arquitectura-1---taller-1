namespace NotificacionesConsola;

/// <summary>
/// Abstraction del patrón Bridge
/// La lógica del tipo mensaje, alerta, advertencia, confirmación
/// </summary>
public abstract class Notificacion
{
    protected readonly IPlataformaNotificacion Plataforma;

    protected Notificacion(IPlataformaNotificacion plataforma)
    {
        Plataforma = plataforma;
    }

     public abstract void Mostrar(string contenido);
}
