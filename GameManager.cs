using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CustomExtensions;

public class GameManager : MonoBehaviour, IManager
{

    public string labelText = "Recolecta los 4 items y gánate la libertad!";
    public const int MAX_ITEMS = 4;

    public bool showWinScreen = false;
    public bool showLossScreen = false;


    // added some logic to get or set the variables to our data

    private int _itemsCollected = 0;

    private string _state;

    public string State
    {
        get {
            return _state;
        }
        set
        {
            _state = value;
        }
    }

    public void Initialize()
    {
        _state = "Mange inicializado";
        _state.YosefDebug();

    }

    private void Start()
    {
        Initialize();
    }

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
            if (_itemsCollected >= MAX_ITEMS)
            {
                labelText = "Has encontrado todos los Items";
                showWinScreen = true;
                Time.timeScale = 0;
            }
            else
            {
                
                labelText = "Item encontrado, te faltan: " + (MAX_ITEMS - _itemsCollected);
            }

            if(value >= 0)
            {
                _itemsCollected = value;
            }
            
            
            
            Debug.LogFormat("Items: {0}", _itemsCollected);
        }
    }

    private int _playerHP = 3;
    public int HP
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

            if(_playerHP <= 0)
            {
                labelText = "Has muerto.... Prueba otra vez";
                showLossScreen = true;
                Time.timeScale = 0;
            }
            else
            {
                labelText = "Ouch, me han dado....";
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
            ShowEndLevel("¡¡ HAS GANADO !!");
        }

        if (showLossScreen)
        {
            ShowEndLevel("¡¡ GAME OVER !!");
        }

        void ShowEndLevel(string message)
        {

            if (GUI.Button(new Rect(Screen.width / 2 - 200, Screen.height - 50, 400, 50),
                message))
            {
                Utilities.RestartLevel();
            }
        }
        
        
    }
}
