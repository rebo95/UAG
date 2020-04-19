using System.Collections;
using System.Collections.Generic;

//Tipo del evento (sirve para esto y para los TrackerAsset)
enum EventType { Shoot, Harvest} //etc

//Clase para representar un evento (en principio hay que hacer una por cada tipo, y que hereden de esta)
public class RatEvent
{
    //Tipo del evento
    EventType type;

    //Contenido común a todos los eventos ¿?
}
