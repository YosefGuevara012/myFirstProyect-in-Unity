using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent)) ]
public class EnemyBehaviour : MonoBehaviour
{
    public Transform patrolRoute;

    public Transform player;
    
    [HideInInspector] // Modifier to hide a public var
    public List<Transform> waypoints;

    [SerializeField] // Modifier to unhide a provate var
    private int locationIndex = 0; // Each waypoint

    private NavMeshAgent _agent;

    private int _lives = 3;
    public int EnemyLives
    {
        get
        {
            return _lives;
        }
        private set
        {

            _lives = value;

            if(_lives <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Ohh, me han matadooooo");

            }
        }
    }

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform; 
        InitializeWaypoints();
        MoveToNextWaypoint();
    }

    void InitializeWaypoints()
    {
        foreach(Transform wp in patrolRoute)
        {
            waypoints.Add(wp);
        }
    }

    void MoveToNextWaypoint()
    {

        if(waypoints.Count == 0)
        {
            return;
        }

        _agent.SetDestination(waypoints[locationIndex].position);
        //locationIndex = (locationIndex + 1) % waypoints.Count; // Fixed Route
        locationIndex = Random.Range(0, waypoints.Count); // Random Route
    }

    private float currentDelay = 0.0f;
    public float maxDelay = 1.0f;

    private void Update()
    {

        if (_agent.remainingDistance < 0.5f && !_agent.pathPending)
        {
            currentDelay += Time.deltaTime;

            if(currentDelay > maxDelay)
            {
                currentDelay = 0.0f;
                MoveToNextWaypoint();
            }

        }

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("Jugador detectado - Voy a por ti!!!");
            _agent.SetDestination(player.position);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if(other.name == "Player")
        {

            Debug.Log("Jugador fuera de rango, regreso a patullar");

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Bullet")
        {
            EnemyLives--;
            Debug.Log("Daño recibido");
        }

    }
}
