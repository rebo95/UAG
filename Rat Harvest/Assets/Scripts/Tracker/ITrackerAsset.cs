
/// <summary>
/// Interfaz de Trackers especializados.
/// </summary>
public interface ITrackerAsset
{
    /// <summary>
    /// Comprueba si un evento debe registrarse en el sistema.
    /// </summary>
    /// <param name="e">El evento a comprobar.</param>
    /// <returns>true si el evento debe registrarse, false en caso contrario.</returns>
    bool Accept(TrackerEvent e);
}

/// <summary>
/// Implementacion para el Tracker especializado en el evento StartGame de la Interfaz de Trackers.
/// </summary>
public class StartGameTracker : ITrackerAsset
{
    /// <summary>
    /// Comprueba si un evento debe registrarse en el sistema.
    /// </summary>
    /// <param name="e">El evento a comprobar.</param>
    /// <returns>true si el evento es de tipo StartGame, false en caso contrario.</returns>
    public bool Accept(TrackerEvent e)
    {
        return e.Type == MyEventType.StartGame;
    }
}

/// <summary>
/// Implementacion para el Tracker especializado en el evento EndGame de la Interfaz de Trackers.
/// </summary>
public class EndGameTracker : ITrackerAsset
{
    /// <summary>
    /// Comprueba si un evento debe registrarse en el sistema.
    /// </summary>
    /// <param name="e">El evento a comprobar.</param>
    /// <returns>true si el evento es de tipo EndGame, false en caso contrario.</returns>
    public bool Accept(TrackerEvent e)
    {
        return e.Type == MyEventType.EndGame;
    }
}