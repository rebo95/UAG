using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sistema de gestion de telemetria.
/// Se implementa siguiendo el patron Singleton.
/// </summary>
public class TrackerManager : MonoBehaviour
{
    public static TrackerManager Instance = null;
    private IPersistence persistenceObject;
    private List<ITrackerAsset> activeTrackers;

    /// <summary>
    /// Identificador del usuario actual.
    /// </summary>
    private int userId;
    /// <summary>
    /// Identificador del juego actual.
    /// </summary>
    private int gameId;
    /// <summary>
    /// Identificador de la sesion actual.
    /// </summary>
    private int sessionId;

    /// <summary>
    /// Modifica el objeto encargado del sistema de persistencia.
    /// </summary>
    /// <param name="persistenceObject"></param>
    public void SetPersistence(IPersistence persistenceObject)
    {
        this.persistenceObject = persistenceObject;
    }

    /// <summary>
    /// Comprueba si un evento recibido debe procesarse, y si es asi lo envia al sistema de persistencia.
    /// </summary>
    /// <param name="e">El evento recibido.</param>
    public void TrackEvent(TrackerEvent e)
    {
        foreach (ITrackerAsset tracker in activeTrackers)
        {
            if (tracker.Accept(e))
            {
                e.UserId = userId;
                e.GameId = gameId;
                e.SessionId = sessionId;
                e.TimeStamp = (long)Time.realtimeSinceStartup;

                persistenceObject.Send(e);
                return;
            }
        }
    }

    void Awake()
    {
        // Inicializacion del Singleton
        if (Instance != null)
        {
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    void Start()
    {
        activeTrackers = new List<ITrackerAsset>();
        activeTrackers.Add(new StartGameTracker());
        SetPersistence(new FilePersistence(new JsonSerializer()));

        StartGameEvent e = new StartGameEvent();
        e.UserId = userId;
        e.GameId = gameId;
        e.SessionId = sessionId;
        e.TimeStamp = 1;
        e.Type = MyEventType.StartGame;

        TrackEvent(e);

        e.TimeStamp = 2;

        TrackEvent(e);
    }
}

// DUDAS:
// ¿La cola de eventos debería ir en el TrackerManager o en el sistema de persistencia? Si va en el sistema de persistencia, ¿es mejor una cola de strings o de TrackerEvents?
// ¿Los métodos del serializador deberían ser estáticos? ¿Esto es compatible en C# con el patrón Strategy? Si no, ¿qué clase cuenta con un objeto serializador?
// Si utilizamos TrackerAssets, ¿es necesario implementarlos con un patrón Visitor puro? ¿Basta con comprobar el tipo del TrackerEvent y devolver true o false?