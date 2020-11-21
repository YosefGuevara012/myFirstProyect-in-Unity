using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Global variables

public static class Constants
{

    public const int valueX = 3222;
}

public class myFirstScript : MonoBehaviour
{
    // Variables de clase

    public int x = 2;
    public int y = 3;
    // Unity detect the variable name separating each word
    public int numberOfPeople = 3; 

    string sentence = "Hola mundo";


    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("this is mi name");
        Debug.LogFormat("The value of x is {0} and the y value is {1} the addition of both numbers x + y is {2}",
                        x, y, x + y);

        sentence = $" Mi favorite number is {x}";

        Debug.Log(sentence);
        
        Debug.Log(Constants.valueX);

        //  Calling Methods

        addTwoNumbers();

        // Pameter Method
        GenerateCharacter("Juan Nieve", 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// add the two numbers
    /// </summary>
    void addTwoNumbers()
    {
        // local variable

        string nameOftheCity = "Bogota";

        Debug.Log(x + y);

        // loop varaible

        if (x == 5)
        {
            string phrase = $"The value of x is {x}";
        }

    }
    public void GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0}, level {1}", name, level);
    }

    public float doYouHaveMoney(float currentMoney)
    {

        return currentMoney - currentMoney;
    }
}
