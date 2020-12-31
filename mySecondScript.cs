using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mySecondScript : MonoBehaviour
{

    // Constantes

    public const float PI = 3.1416f; // No se puede reasignar un valor

    // Solo Lectura

    public readonly int numberOfEnemies; // solo se puede asignar en un lugar en el constructor

    // Start is called before the first frame update

    mySecondScript()
    {
        numberOfEnemies = 5;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
