using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{

    public string name;
    public int exp = 5;

    public Character()
    {
        name = "Jean Carlo";
    }

    public Character(string name)
    {

        this.name = name;

    }

    public void PrintCharacterStatus()
    {

        Debug.LogFormat("Character name: {0} - {1} experience", this.name, this.exp);
    }

}