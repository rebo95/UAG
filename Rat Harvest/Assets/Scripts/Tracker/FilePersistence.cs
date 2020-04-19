
/// <summary>
/// Implementacion para servidor remoto de la Interfaz del Sistema de Persistencia.
/// </summary>
public class FilePersistence : IPersistence
{
    /// <summary>
    /// Serializa y almacena un evento (persistencia sincrona).
    /// Serializa y encola un evento (persistencia asíncrona).
    /// </summary>
    /// <param name="e">El evento recibido por el Sistema de Persistencia.</param>
    public void Send(TrackerEvent e)
    {
        // TODO
    }

    /// <summary>
    /// Vuelca todos los elementos de la cola de eventos.
    /// </summary>
    public void Flush()
    {
        // TODO
    }
}

