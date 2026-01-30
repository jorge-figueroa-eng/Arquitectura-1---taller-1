namespace NotificacionesConsola;
/// <summary>
/// Notificación de tipo Alerta - Refined Abstraction
/// </summary>
public class NotificacionAlerta : Notificacion
{
    public NotificacionAlerta(IPlataformaNotificacion plataforma) : base(plataforma) { }

    public override void Mostrar(string contenido) => Plataforma.MostrarAlerta(contenido);
}
