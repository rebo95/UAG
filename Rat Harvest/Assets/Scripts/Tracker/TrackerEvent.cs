using Newtonsoft.Json;
using UnityEngine;

/// <summary>
/// Tipo enumerado para identificar los diferentes eventos.
/// </summary>
public enum MyEventType { StartGame, EndGame }

/// <summary>
/// Clase base que define los eventos.
/// </summary>
public abstract class TrackerEvent
{
    /// <summary>
    /// Identificador del usuario que ha generado el evento.
    /// </summary>
    public int UserId { get; set; }
    /// <summary>
    /// Identificador del juego en el que se ha generado el evento.
    /// </summary>
    public int GameId { get; set; }
    /// <summary>
    /// Identificador de la sesion en la que se ha generado el evento.
    /// </summary>
    public int SessionId { get; set; }
    /// <summary>
    /// Instante temporal en el que se ha generado el evento.
    /// </summary>
    public long TimeStamp { get; set; }
    /// <summary>
    /// Identificador del tipo de evento.
    /// </summary>
    public MyEventType Type { get; set; }

    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public abstract string ToJson();
    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public abstract string ToCSV();
}

/// <summary>
/// Clase que define el evento de inicio de sesion.
/// </summary>
public class StartGameEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        string jsonTypeNameAll = JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        });

        return jsonTypeNameAll;
    }
}

/// <summary>
/// Clase que define el evento de fin de sesion.
/// </summary>
public class EndGameEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}


/// <summary>
/// Clase que define el evento que determina cuando se interactua con el botón
/// de play y lanza la pantalla tutorial de What to do.
/// </summary>
public class WhatToDoShownEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}


/// <summary>
/// Clase que define el evento que determina cuando se cumple el primer minuto de partida.
/// </summary>
public class FirstMinEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}


/// <summary>
/// Clase que define el evento que determina cuando cuando se interactúa con 
/// un parterre para sembrar una planta.
/// </summary>
public class UserPlantEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}

/// <summary>
/// Clase que define el evento que determina cuando 
/// el jugador recoge una plantación.
/// </summary>
public class UserHarvestEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}


/// <summary>
/// Clase que define el evento que determina cuando 
/// el jugador deposita los tomates en la caja de cultivo
/// </summary>
public class UserStoreEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}


/// <summary>
/// Clase que define el evento que determina cuando 
/// el jugador pulsa el botón izquierdo y dispara
/// </summary>
public class WeaponShotEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}


/// <summary>
/// Clase que define el evento que servirá para determinar el tiempo transcurrido 
/// entre los eventos de empezar partida y la aparición de la imagen tutorial
/// </summary>
public class ReadTime : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}


/// <summary>
/// Clase que define el evento que servirá para determinar el tiempo transcurrido 
/// con la carga máxima de tomates en el la bolsa
/// </summary>
public class MaxLoadTimeEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}

/// <summary>
/// Clase que define el evento que servirá para determinar el número de 
/// ocasiones en las que se interactúa con los parterres plantando una semilla
/// en el primer minuto de juego
/// </summary>
public class PlantedFirstMinEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}


/// <summary>
/// Clase que define el evento que servirá para determinar el número de 
/// ocasiones en las que se interactúa con el botón derecho del ratón y disparando
/// en el primer minuto de juego
/// </summary>
public class ShotFirstMinEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}

/// <summary>
/// Clase que define el evento que servirá para determinar 
/// las posiciones por las que pasa el jugador durante el primer minuto de juego
/// en el primer minuto de juego
/// </summary>
public class PlayerPosFirstMinEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}


/// <summary>
/// Clase que define el evento que servirá para determinar el número de 
///puntos por minuto que consigue el jugador en cada minuto de partida
/// </summary>
public class PointsMinEvent : TrackerEvent
{
    /// <summary>
    /// Traduce el evento al formato Json.
    /// </summary>
    /// <returns>Una cadena de texto en formato Json.</returns>
    public override string ToCSV()
    {
        // TODO
        return "";
    }

    /// <summary>
    /// Traduce el evento al formato CSV.
    /// </summary>
    /// <returns>Una cadena de texto en formato CSV.</returns>
    public override string ToJson()
    {
        // TODO
        return "";
    }
}
