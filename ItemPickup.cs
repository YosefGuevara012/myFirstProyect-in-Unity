using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            // Player pickup the healthItem
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Objeto recolectado");


        }

    }


}
