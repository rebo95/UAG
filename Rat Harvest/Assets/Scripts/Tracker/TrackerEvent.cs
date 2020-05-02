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