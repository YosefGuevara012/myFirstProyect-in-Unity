using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Global variables


public class myFirstScript : MonoBehaviour
{
    

    
    void Start()
    {

        Character hero = new Character();
        Debug.LogFormat("Hero name: {0} - {1} experience", hero.name, hero.exp);

        Character heroine = new Character("Lara Croft");
        Debug.LogFormat("Heroine name: {0} -  {1} experience ", heroine.name, heroine.exp);
        

    }

   
}

