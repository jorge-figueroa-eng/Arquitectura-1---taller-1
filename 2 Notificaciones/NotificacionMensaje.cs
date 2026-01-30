namespace NotificacionesConsola;

public class NotificacionMensaje : Notificacion
{
    public NotificacionMensaje(IPlataformaNotificacion plataforma) : base(plataforma) { }

    public override void Mostrar(string contenido) => Plataforma.MostrarMensaje(contenido);
}
