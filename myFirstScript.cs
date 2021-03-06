﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Global variables


public class myFirstScript : MonoBehaviour
{
    public Transform cameraTransfrom;
    public Light directionalLight;
    public Transform LightTransorm;


    void Start()
    {

        // Classes called with the same name, point to the same memory place
        Character hero = new Character();
        hero.PrintCharacterStatus();

        Character heroine = new Character("Lara Croft");
        heroine.PrintCharacterStatus();

        // example
        Character hero2 = hero;
        hero2.PrintCharacterStatus();

        // If you change one of them
        hero2.name = "Carlos";

        // Result
        hero.PrintCharacterStatus();
        hero2.PrintCharacterStatus();


        // It does not happen the same with the Structures
        // Because does not point to the same memory place

        Weapon sword = new Weapon("Wood Sword", 5);
        Weapon sword2 = sword;


        sword2.name = "Excalibur";
        sword2.damage = 1000;

        sword.PrintWeaponStats();
        sword2.PrintWeaponStats();

        Paladin Paladin1 = new Paladin("Arhur", sword);

        Archer Archer1 = new Archer("Legolas", new Weapon ("Magic arch", 25));


        Magician Magician1 = new Magician("Grandalf");

        List<Character> party = new List<Character>();
        party.Add(Paladin1);
        party.Add(Archer1);
        party.Add(Magician1);


        foreach(Character c in party)
        {

            c.PrintCharacterStatus();
        }


        // El script de esta camara
        // Podemos consultar sus componentes

        Transform theTransform = GetComponent<Transform>();
        Debug.Log(theTransform.position);
        Debug.Log(theTransform.rotation);


        GameObject myLight = GameObject.Find("Directional Light");
        Transform t = myLight.GetComponent<Transform>();
        Debug.Log("la lus está en:" + t.position);

    }

   
}

