using NotificacionesConsola;

Console.WriteLine("=== Gestor de notificaciones Patrón de Diseño Bridge) ===\n");

// Plataformas (implementadores). Concrete Implementations
IPlataformaNotificacion escritorio = new PlataformaEscritorio();
IPlataformaNotificacion movil = new PlataformaMovil();
IPlataformaNotificacion web = new PlataformaWeb();



Console.WriteLine("\n--- Mensajes ---");
Notificacion msgEscritorio = new NotificacionMensaje(escritorio);
var msgMovil = new NotificacionMensaje(movil);
var msgWeb = new NotificacionMensaje(web);
msgEscritorio.Mostrar("Mensaje en Escritorio");
msgMovil.Mostrar("Mensaje en Móvil");
msgWeb.Mostrar("Mensaje en Web");

Console.WriteLine("\n--- Alertas  ---");
var alertaEscritorio = new NotificacionAlerta(escritorio);
var alertaMovil = new NotificacionAlerta(movil);
var alertaWeb = new NotificacionAlerta(web);
alertaEscritorio.Mostrar("Alerta en Escritorio");
alertaMovil.Mostrar("Alerta en Móvil");
alertaWeb.Mostrar("Alerta en Web");

Console.WriteLine("\n--- Advertencias ---");
var advertenciaEscritorio = new NotificacionAdvertencia(escritorio);
var advertenciaMovil = new NotificacionAdvertencia(movil);
var advertenciaWeb = new NotificacionAdvertencia(web);
advertenciaEscritorio.Mostrar("Advertencia en Escritorio");
advertenciaMovil.Mostrar("Advertencia en Móvil");
advertenciaWeb.Mostrar("Advertencia en Web");



Console.WriteLine("\n--- Confirmaciones ---");
var confirmacionEscritorio = new NotificacionConfirmacion(escritorio);
var confirmacionMovil = new NotificacionConfirmacion(movil);
var confirmacionWeb = new NotificacionConfirmacion(web);
confirmacionEscritorio.Mostrar("Confirmación en Escritorio");
confirmacionMovil.Mostrar("Confirmación en Móvil");
confirmacionWeb.Mostrar("Confirmación en Web");


Console.WriteLine("\n--- Notificaciones ---");
Notificacion notif = new NotificacionMensaje(escritorio);
notif.Mostrar("Primero en escritorio");
// En un caso real podrías asignar otra plataforma si la abstracción lo permitiera;
// aquí mostramos otra instancia con otra plataforma para simular el cambio.
Notificacion notifMovil = new NotificacionMensaje(movil);
notifMovil.Mostrar("Ahora en móvil");

Console.WriteLine("\nFin del demo.");
