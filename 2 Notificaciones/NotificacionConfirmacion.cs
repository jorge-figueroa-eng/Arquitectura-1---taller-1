namespace NotificacionesConsola;

/// <summary>
/// Notificación de tipo Confirmación - Refined Abstraction
/// </summary>
public class NotificacionConfirmacion : Notificacion
{
    public NotificacionConfirmacion(IPlataformaNotificacion plataforma) : base(plataforma) { }

    public override void Mostrar(string contenido) => Plataforma.MostrarConfirmacion(contenido);
}
