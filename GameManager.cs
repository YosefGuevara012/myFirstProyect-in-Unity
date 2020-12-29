using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


  
    // added some logic to get or set the variables to our data

    private int _itemsCollected = 0;
    public int Items
    {
        get
        {
            // Aqui poneis codigo cuando se cosnsulta una variable
            return _itemsCollected;

        }
        set
        {
            _itemsCollected = value;
            Debug.LogFormat("Items: {0}", _itemsCollected);
        }
    }

    private int _playerHP = 0;
    private int HP
    {
        get
        {
            return _playerHP;

        }
        set
        {   
            if (value >= 0 && value <= 3)
            {

               _playerHP = value;

            }
           
            Debug.LogFormat("Vidas: {0}", _playerHP);
        }
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
