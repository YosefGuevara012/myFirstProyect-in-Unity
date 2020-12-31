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

    // Method Overload
    // Diferent ways to do the same action
    public bool AttackEnemy(int damage) { return true; }
    public bool AttackEnemy(string player) { return true; }
    public bool AttackEnemy(float damage) { return true; }
    public bool AttackEnemy(float damage, string player) { return true; }
    public void AttackEnemy(){}
    public float AttackEnemy(bool hello) { return 5.0f; }

    private void Start()
    {
        AttackEnemy();
        AttackEnemy(true);
        AttackEnemy(5.0f);
    }

}
