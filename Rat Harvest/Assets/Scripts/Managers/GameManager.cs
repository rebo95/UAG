using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private PlayerManager playerManager;
    [SerializeField] private int pointsToWin;
    public int PointsToWin { get { return this.pointsToWin; } }


    private void Awake()
    {
        instance = this;
    }

    private bool Victory()
    {
        bool b = false;

        if (playerManager.PlayerScore >= pointsToWin)
            b = true;

        return b;
    }

    public void EndGame()
    {
        //TODOTracker
        Debug.Log("EVENTO: END_GAME, finalScore = " + playerManager.PlayerScore);
        if (Victory())
            SceneManager.instance.loadYouWin();
        else
            SceneManager.instance.loadYouLose();
    }

    //                                                                //
    //          A PARTIR DE AQUÍ ES AÑADIDO PARA EL TRACKER           //
    //                                                                //

    //Atributos
    private bool firstMin = true;

    //Tiros y plantaciones hechas
    private int shots = 0;
    private int planted = 0;
    
    //Para trackear la carga máxima
    private bool maxLoad = false;
    private float maxLoadTime = 0;
    private float maxLoadCurrent = 0;

    //Lista de posiciones del jugador
    const int POS_RATE = 2; //Cada cuántos segundos queremos que se registre la posición del jugador (2s de momento)
    List<Vector2> positions = new List<Vector2>();
    private float positionsTimer = 0;


    //Actualiza el tiempo
    private void Update()
    {
        if(maxLoad)
            maxLoadCurrent += Time.deltaTime;
        if (firstMin)
        {
            positionsTimer += Time.deltaTime;

            //Registramos la posición del jugador y la añadimos a la lista
            if (positionsTimer > POS_RATE)
            {
                Debug.Log("PlayerPos saved");
                Vector3 playerPos = playerManager.transform.position;
                positions.Add(new Vector2(playerPos.x, playerPos.y));
                positionsTimer = 0;
            }
        }
    }

    //   Todas estas funciones "Notify" se llaman desde otros scripts;   //
    //   la gracia es hacerlo todo aquí ya que tenemos acceso al         //
    //   PlayerManager y que no sea una locura                           //

    //Ha pasado un minuto en el juego
    public void NotifyMinutePassed()
    {
        //Primer minuto de partida
        if (firstMin)
        {
            //TODOTracker
            Debug.Log("EVENTO: FIRST_MIN");

            //TODOTracker
            Debug.Log("EVENTO: PLANTED_FIRSTMIN, planted = " + planted);

            //TODOTracker
            Debug.Log("EVENTO: SHOTS_FIRSTMIN, shots = " + shots);

            //TODOTracker
            Debug.Log("EVENTO: PLAYERPOS_FIRSTMIN, positions = ");

            firstMin = false;
        }

        //Puntos
        //TODOTracker
        Debug.Log("EVENTO: POINTS_MIN, points = " + playerManager.PlayerScore);
    }

    //Se ha disparado el arma
    public void NotifyShot()
    {
        //TODOTracker
        Debug.Log("EVENTO: WEAPON_SHOT");
        shots++;
    }

    //Se ha plantado un tomate
    public void NotifyPlant()
    {
        //TODOTracker
        Debug.Log("EVENTO: USER_PLANT");
        planted++;
    }

    //Se han recogido tomates
    public void NotifyHarvest(int plantState, int tomatoes, int playerLoad)
    {
        //TODOTracker
        Debug.Log("EVENTO: USER_HARVEST, plantState = " + plantState + ", tomatoes = " + tomatoes);

        //Hemos cogido Máxima carga
        if (playerLoad == playerManager.BagCapacity)
        {
            Debug.Log("MAX_LOAD");
            maxLoad = true;
        }   
    }

    //Se han depositado los tomates
    public void NotifyStore(int score)
    {
        //TODOTracker
        Debug.Log("EVENTO: USER_STORE, score = " + score);

        //Veníamos con la carga máxima
        if (maxLoad)
        {
            //New record
            Debug.Log("New Maxload");
            if(maxLoadCurrent > maxLoadTime)
                maxLoadTime = maxLoadCurrent;
            maxLoad = false;
            maxLoadCurrent = 0;
        }
    }
}
