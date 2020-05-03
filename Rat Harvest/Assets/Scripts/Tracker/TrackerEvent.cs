using Newtonsoft.Json;
using UnityEngine;

/// <summary>
/// Tipo enumerado para identificar todos los diferentes eventos.
/// </summary>
public enum MyEventType { StartGame, EndGame, WhatToDoShown, FirstMin,
    UserPlant, UserHarvest, UserStore, WeaponShot, ReadTime, MaxLoadTime,
    PlantedFirstMin, ShotsFirstMin, PlayerPosFirstMin, PointsMin }

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

//TODO: terminar de hacer las clases de eventos (ponerles sus atributos específicos y hacerles constructoras que los seteen)

/// <summary>
/// Clase que define el evento de inicio de sesion.
/// </summary>
public class StartGameEvent : TrackerEvent
{
    public StartGameEvent() { Type = MyEventType.StartGame; }

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
    public EndGameEvent() { Type = MyEventType.EndGame; }

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
/// Clase que define el evento que determina cuando se interactua con el botón
/// de play y lanza la pantalla tutorial de What to do.
/// </summary>
public class WhatToDoShownEvent : TrackerEvent
{
    public WhatToDoShownEvent() { Type = MyEventType.WhatToDoShown; }

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
/// Clase que define el evento que determina cuando se cumple el primer minuto de partida.
/// </summary>
public class FirstMinEvent : TrackerEvent
{
    public FirstMinEvent() { Type = MyEventType.FirstMin; }

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
/// Clase que define el evento que determina cuando cuando se interactúa con 
/// un parterre para sembrar una planta.
/// </summary>
public class UserPlantEvent : TrackerEvent
{
    public UserPlantEvent() { Type = MyEventType.UserPlant; }

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
/// Clase que define el evento que determina cuando 
/// el jugador recoge una plantación.
/// </summary>
public class UserHarvestEvent : TrackerEvent
{
    public UserHarvestEvent() { Type = MyEventType.UserHarvest; }

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
/// Clase que define el evento que determina cuando 
/// el jugador deposita los tomates en la caja de cultivo
/// </summary>
public class UserStoreEvent : TrackerEvent
{
    public UserStoreEvent() { Type = MyEventType.UserStore; }

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
/// Clase que define el evento que determina cuando 
/// el jugador pulsa el botón izquierdo y dispara
/// </summary>
public class WeaponShotEvent : TrackerEvent
{
    public WeaponShotEvent() { Type = MyEventType.WeaponShot; }

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
/// Clase que define el evento que servirá para determinar el tiempo transcurrido 
/// entre los eventos de empezar partida y la aparición de la imagen tutorial
/// </summary>
public class ReadTimeEvent : TrackerEvent
{
    public ReadTimeEvent() { Type = MyEventType.ReadTime; }

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
/// Clase que define el evento que servirá para determinar el tiempo transcurrido 
/// con la carga máxima de tomates en el la bolsa
/// </summary>
public class MaxLoadTimeEvent : TrackerEvent
{
    public MaxLoadTimeEvent() { Type = MyEventType.MaxLoadTime; }

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
/// Clase que define el evento que servirá para determinar el número de 
/// ocasiones en las que se interactúa con los parterres plantando una semilla
/// en el primer minuto de juego
/// </summary>
public class PlantedFirstMinEvent : TrackerEvent
{
    public PlantedFirstMinEvent() { Type = MyEventType.PlantedFirstMin; }

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
/// Clase que define el evento que servirá para determinar el número de 
/// ocasiones en las que se interactúa con el botón derecho del ratón y disparando
/// en el primer minuto de juego
/// </summary>
public class ShotsFirstMinEvent : TrackerEvent
{
    public ShotsFirstMinEvent() { Type = MyEventType.ShotsFirstMin; }

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
/// Clase que define el evento que servirá para determinar 
/// las posiciones por las que pasa el jugador durante el primer minuto de juego
/// en el primer minuto de juego
/// </summary>
public class PlayerPosFirstMinEvent : TrackerEvent
{
    public PlayerPosFirstMinEvent() { Type = MyEventType.PlayerPosFirstMin; }

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
/// Clase que define el evento que servirá para determinar el número de 
///puntos por minuto que consigue el jugador en cada minuto de partida
/// </summary>
public class PointsMinEvent : TrackerEvent
{
    public PointsMinEvent() { Type = MyEventType.PointsMin; }

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
