using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerManager : MonoBehaviour
{
    //Instancia
    private static TrackerManager instance = null;

    //Parámetros persistentes
    float timestamp;    string idJuego;    string idSesion;    string idUsuario;

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


    //Para obtener la instancia del Singleton
    public static void TrackEvent (RatEvent e)
    {
        //Añadirlo a la cola o algo sabe
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
