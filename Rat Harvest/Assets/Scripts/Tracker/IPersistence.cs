
/// <summary>
/// Interfaz del Sistema de Persistencia.
/// </summary>
public interface IPersistence
{
    /// <summary>
    /// Serializa y almacena un evento (persistencia sincrona).
    /// Serializa y encola un evento (persistencia asíncrona).
    /// </summary>
    /// <param name="e">El evento recibido por el Sistema de Persistencia.</param>
    void Send(TrackerEvent e);

    /// <summary>
    /// Vuelca todos los elementos de la cola de eventos.
    /// </summary>
    void Flush();
}
