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
    public int numberOfPeople = 3; // Unity detect the variable name separating each word
    string sentence = "Hola mundo";

    public bool dungeonKey = true;

    public int money = 50;


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

        // Void conditions

        Conditions();

        // Data Structures

        DataStructures();

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

    void Conditions()
    {

        if (dungeonKey)
        {
            Debug.Log("Go inside");
        }
        else
        {
            Debug.Log("Find the key");
        }


        if( dungeonKey && money == 50)
        {
            Debug.Log("You are great");
        }
        else
        {
            Debug.Log("Find some money and the Key");
        }

        int z = 4;

        switch (z)
        {

            case 1:

                Debug.Log("Hi");
                break;

            case 2:

                Debug.Log("How are you");
                break;

            case 3:
            case 4:
                Debug.Log("My name is carlos");
                break;

            default:
                break;
        }

        int[] arry = { 2, 4, 5 };

        for (int i = 0; i < arry.Length; i++)
        {
            Debug.Log(arry[i]);
        }

        bool lean = true;

        Debug.Log(lean ? "Charles is alive" : "Charles is death");

        foreach (int value in arry)
        {
            Debug.Log(value + "Arry value");
        }

        int numbersOflives = 5;

        while(numbersOflives >= 0)
        {
            Debug.LogFormat("Number of lives {0}", numbersOflives);
            numbersOflives--;

        }


    }

    void DataStructures()
    {

        // Arrays
        int[] ranking = { 2, 4, 5 };

        Debug.Log(ranking[2]);

        Debug.Log(ranking.Length);


        // Lists

        List<string> group =  new List<string>{ "Jhon", "Jaime", "Mar" };

        Debug.Log(group[1]);

        Debug.LogFormat("Our comunity has {0} members", group.Count);

        // List Methods 

        group.Add("jack");
        group.Add("Fike");

        group.Insert(2,"Mack");

        group.Remove("Fike");

        Debug.LogFormat("Our comunity has {0} members", group.Count);


        // Dictionaries

        Dictionary<string, int> inventory = new Dictionary<string, int>()
        {
            {"Position",5 },
            {"Healt",523 },
            {"Sword",52 },
            {"Axe",345 },
            {"Arrow",10 }

        };

        Debug.Log(inventory["Position"]);


        inventory["Poison"] = 7;

        Debug.Log(inventory["Position"]);

        if (inventory.ContainsKey("Rope"))
        {
            inventory["Poison"] = 10;
        }
        else
        {
            inventory.Remove("Poison");
        }


        foreach (KeyValuePair<string, int> kvp in inventory)
        {
            Debug.LogFormat("Item {0} - {1}",kvp.Key, kvp.Value);
        }


    }

}

