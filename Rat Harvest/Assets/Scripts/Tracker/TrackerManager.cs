using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerManager : MonoBehaviour
{
    //Instancia
    private static TrackerManager instance = null;

    //Parámetros persistentes (comunes a todos los eventos en un mismo contexto)
    float timestamp;    string idJuego;    string idSesion;    string idUsuario;

    //Sistema de persistencia (para guardar los eventos)
    IPersistenceSystem persistenceSys;    //Lista de TrackerAssets, uno de cada tipo de evento    List<ITrackerAsset> trackerAssets;

    //Constructora privada
    private TrackerManager()
    {
    }

    //Para obtener la instancia del Singleton
    public static TrackerManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new TrackerManager();
            }
            return instance;
        }
    }


    //Inicialización del sistema de telemetría
    public static void Init()
    {
        //Crear Tracker Assets, inicizalizar timestamp e ids
    }


    //Añade un evento a la cola
    public static void TrackEvent (RatEvent e)
    {
        //Preguntar a todos los TrackerAssets que si le interesa
    }

    //Finalización del sistema de telemetría
    public static void End()
    {

    }


    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
