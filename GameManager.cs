using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public string labelText = "Recolecta los 4 items y gánate la libertad!";
    public int maxItems = 4;

  
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
            
            if(_itemsCollected >= maxItems)
            {
                labelText = "Has encontrado todos los Items";
            }
            else
            {
                _itemsCollected = value;
                labelText = "Item encontrado, te faltan: " + (maxItems - _itemsCollected);
            }

            if(value >= 0)
            {
                _itemsCollected = value;
            }
            
            
            
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


    private void OnGUI()
    {
        GUI.Box(new Rect( /*dist x izquierda*/25,
                          /*dist y arriba*/25,
                          /*Anchi*/180,
                          /*alto*/25), "Vida: " + _playerHP);

        GUI.Box(new Rect(25, 60, 180, 25), "Items recogidos: " + _itemsCollected);

        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 200, 50),
            labelText);
    
    }
}
