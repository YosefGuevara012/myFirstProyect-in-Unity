using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public GameManager gameManager;

    public void Start()
    {
        gameManager = GameObject.Find("Game Manager").
            GetComponent<GameManager>(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            // Player pickup the healthItem
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Objeto recolectado");
            gameManager.Items++;

        }

    }


}
