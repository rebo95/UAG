﻿
using UnityEngine;

/// <summary>
/// Implementacion para servidor remoto de la Interfaz del Sistema de Persistencia.
/// </summary>
public class FilePersistence : IPersistence
{
    ISerializer serializer;

    public FilePersistence(ISerializer serializer)
    {
        this.serializer = serializer;
    }

    public void SetSerializer(ISerializer serializer)
    {
        this.serializer = serializer;
    }

    /// <summary>
    /// Serializa y almacena un evento (persistencia sincrona).
    /// Serializa y encola un evento (persistencia asíncrona).
    /// </summary>
    /// <param name="e">El evento recibido por el Sistema de Persistencia.</param>
    public void Send(TrackerEvent e)
    {
        string serializedEvent = serializer.Serialize(e);
        Debug.Log(serializedEvent);
    }

    /// <summary>
    /// Vuelca todos los elementos de la cola de eventos.
    /// </summary>
    public void Flush()
    {
        // TODO
    }
}

