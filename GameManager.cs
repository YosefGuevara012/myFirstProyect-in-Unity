using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public string labelText = "Recolecta los 4 items y gánate la libertad!";
    public int maxItems = 4;

    public bool showWinScreen = false;

  
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
            if (_itemsCollected >= maxItems)
            {
                labelText = "Has encontrado todos los Items";
                showWinScreen = true;
                Time.timeScale = 0;
            }
            else
            {
                
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

        GUI.Box(new Rect(25, 65, 180, 25), "Items recogidos: " + _itemsCollected);

        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 200, 50),
            labelText);

        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height - 50, 400, 50),
                "¡¡ HAS GANADO !!"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
    
    }
}
