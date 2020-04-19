
/// <summary>
/// Interfaz de Serializacion.
/// </summary>
public interface ISerializer
{
    /// <summary>
    /// Traduce un evento al formato especificado por el Serializador.
    /// </summary>
    /// <param name="e">El evento a traducir.</param>
    /// <returns>Una cadena de texto en el formato especificado por el Serializador.</returns>
    public string Serialize(TrackerEvent e);
}

// Posiblemente necesitemos un sistema de criptografia para garantizar la integridad de los datos