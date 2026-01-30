namespace NotificacionesConsola;

/// <summary>
/// Interface del patrón Bridge
/// Cada plataforma escritorio, móvil, web implementa esta interfaz de forma distinta.
/// </summary>
public interface IPlataformaNotificacion
{
    void MostrarMensaje(string contenido);
    void MostrarAlerta(string contenido);
    void MostrarAdvertencia(string contenido);
    void MostrarConfirmacion(string contenido);
}
