﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEditor;

/// <summary>
/// Sistema de gestion de telemetria.
/// Se implementa siguiendo el patron Singleton.
/// </summary>
public class TrackerManager : MonoBehaviour
{
    public static TrackerManager Instance = null;
    private IPersistence persistenceObject;
    private List<ITrackerAsset> activeTrackers;
    private TrackerType types;


    public bool MainMenu;
    public bool FirstMinute;
    public bool ScoreSystem;

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
    private string sessionId;

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
        Debug.Log("Recibido evento '" + e.Type.ToString() + "'");
        foreach (ITrackerAsset tracker in activeTrackers)
        {
            //Con que le interese a un solo tracker es suficiente para que el evento se
            //procese y se mande al sistema de persistencia
            if (tracker.Accept(e))
            {
                Debug.Log("Aceptado");
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
        sessionId = CreateSessionId();

        //JSON
        SetPersistence(new FilePersistence(new JsonSerializer()));

        //Metemos los trackers que sean necesarios
        activeTrackers = new List<ITrackerAsset>();
        if (MainMenu)
            activeTrackers.Add(new MainMenuTracker());
        if(FirstMinute)
            activeTrackers.Add(new FirstMinTracker());
        if (ScoreSystem)
            activeTrackers.Add(new ScoreSystemTracker());


        //StartGameEvent e = new StartGameEvent();
        //e.UserId = userId;
        //e.GameId = gameId;
        //e.SessionId = sessionId;
        //e.TimeStamp = 1;

        //TrackEvent(e);
        //e.TimeStamp = 2;
        //TrackEvent(e);
    }

    // Crea un identificador único para la sesión de juego usando la fecha actual, hora, minutos y segundos
    private string CreateSessionId()
    {
        DateTime dt = DateTime.Now;
        int dtMillisecond = DateTime.Now.Millisecond;
        string id = Convert.ToString(dt) + ":" + Convert.ToString(dtMillisecond);

        return id;
    }
}

// DUDAS:
// ¿La cola de eventos debería ir en el TrackerManager o en el sistema de persistencia? Si va en el sistema de persistencia, ¿es mejor una cola de strings o de TrackerEvents?
// ¿Los métodos del serializador deberían ser estáticos? ¿Esto es compatible en C# con el patrón Strategy? Si no, ¿qué clase cuenta con un objeto serializador?
// Si utilizamos TrackerAssets, ¿es necesario implementarlos con un patrón Visitor puro? ¿Basta con comprobar el tipo del TrackerEvent y devolver true o false?