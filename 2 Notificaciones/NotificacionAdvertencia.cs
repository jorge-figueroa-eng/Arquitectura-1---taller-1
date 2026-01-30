namespace NotificacionesConsola;

/// <summary>
/// Notificación de tipo Advertencia - Refined Abstraction
/// </summary>
public class NotificacionAdvertencia : Notificacion
{
    public NotificacionAdvertencia(IPlataformaNotificacion plataforma) : base(plataforma) { }

    public override void Mostrar(string contenido) => Plataforma.MostrarAdvertencia(contenido);
}
