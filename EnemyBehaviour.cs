using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform patrolRoute;
    public List<Transform> waypoints;

    private void Start()
    {
        InitializeWaypoints();
    }

    void InitializeWaypoints()
    {
        foreach(Transform wp in patrolRoute)
        {
            waypoints.Add(wp);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("Jugador detectado - Voy a por ti!!!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if(other.name == "Player")
        {

            Debug.Log("Jugador fuera de rango, regreso a patullar");

        }

    }
}
