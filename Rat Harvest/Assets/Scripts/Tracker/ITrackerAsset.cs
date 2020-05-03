
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

///// <summary>
///// Implementacion para el Tracker especializado en el evento StartGame de la Interfaz de Trackers.
///// </summary>
//public class StartGameTracker : ITrackerAsset
//{
//    /// <summary>
//    /// Comprueba si un evento debe registrarse en el sistema.
//    /// </summary>
//    /// <param name="e">El evento a comprobar.</param>
//    /// <returns>true si el evento es de tipo StartGame, false en caso contrario.</returns>
//    public bool Accept(TrackerEvent e)
//    {
//        return e.Type == MyEventType.StartGame;
//    }
//}

///// <summary>
///// Implementacion para el Tracker especializado en el evento EndGame de la Interfaz de Trackers.
///// </summary>
//public class EndGameTracker : ITrackerAsset
//{
//    /// <summary>
//    /// Comprueba si un evento debe registrarse en el sistema.
//    /// </summary>
//    /// <param name="e">El evento a comprobar.</param>
//    /// <returns>true si el evento es de tipo EndGame, false en caso contrario.</returns>
//    public bool Accept(TrackerEvent e)
//    {
//        return e.Type == MyEventType.EndGame;
//    }
//}

/// <summary>
/// Implementacion para el Tracker especializado en comprobar que el jugador 
/// lee con suficiente detenimiento la pantalla de instrucciones previa al juego
/// </summary>
public class MainMenuTracker : ITrackerAsset
{
    /// <summary>
    /// Comprueba si un evento debe registrarse en el sistema.
    /// </summary>
    /// <param name="e">El evento a comprobar.</param>
    /// <returns>true si el evento es de tipo EndGame, false en caso contrario.</returns>
    public bool Accept(TrackerEvent e)
    {
        return (e.Type == MyEventType.WhatToDoShown || e.Type == MyEventType.StartGame || e.Type == MyEventType.ReadTime);
    }
}

/// <summary>
/// Implementacion para el Tracker especializado en comprobar que el jugador 
/// entiende lo que debe hacer en el primer minuto de partida
/// </summary>
public class FirstMinTracker : ITrackerAsset
{
    /// <summary>
    /// Comprueba si un evento debe registrarse en el sistema.
    /// </summary>
    /// <param name="e">El evento a comprobar.</param>
    /// <returns>true si el evento es de tipo EndGame, false en caso contrario.</returns>
    public bool Accept(TrackerEvent e)
    {
        return (e.Type == MyEventType.StartGame || e.Type == MyEventType.FirstMin || e.Type == MyEventType.WeaponShot ||
            e.Type == MyEventType.PlayerPosFirstMin || e.Type == MyEventType.PlantedFirstMin || e.Type == MyEventType.ShotsFirstMin);
    }
}

/// <summary>
/// Implementacion para el Tracker especializado en comprobar que el jugador 
/// entiende el sistema de puntuación del juego
/// </summary>
public class ScoreSystemTracker : ITrackerAsset
{
    /// <summary>
    /// Comprueba si un evento debe registrarse en el sistema.
    /// </summary>
    /// <param name="e">El evento a comprobar.</param>
    /// <returns>true si el evento es de tipo EndGame, false en caso contrario.</returns>
    public bool Accept(TrackerEvent e)
    {
        return (e.Type == MyEventType.StartGame || e.Type == MyEventType.UserHarvest || e.Type == MyEventType.UserStore ||
              e.Type == MyEventType.PointsMin || e.Type == MyEventType.MaxLoadTime || e.Type == MyEventType.EndGame);
    }
}
