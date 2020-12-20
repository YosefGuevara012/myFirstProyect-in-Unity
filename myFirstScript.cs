using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Global variables


public class myFirstScript : MonoBehaviour
{
    

    
    void Start()
    {

        Character hero = new Character();
        hero.PrintCharacterStatus();

        Character heroine = new Character("Lara Croft");
        heroine.PrintCharacterStatus();
        

    }

   
}

