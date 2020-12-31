using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; 

public static class Utilities
{

    public static int playerDeaths = 0;

    ///<summary>
    /// Restarts the same level
    ///</summary>

    public static void RestartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;

        Debug.Log("Muertes del jugador:" + playerDeaths);
        string message = UpdateDeathCount(ref playerDeaths);
        Debug.Log("Muertes totales: " + playerDeaths);

    }

    ///<summary>
    /// Restarts an specific level
    ///</summary>
    public static void RestartLevel(int buildIndex)
    {

        if(buildIndex < 0)
        {
            throw new System.ArgumentException("El indice no pude ser negativo");
        }

        if(buildIndex > SceneManager.sceneCount)
        {
            throw new System.ArgumentException("El numero el mayor a la cantitdad de escenas existentes");
        }

        SceneManager.LoadScene(buildIndex);
        Time.timeScale = 1.0f;
    }

    public static string UpdateDeathCount(ref int countRef)
    {

        countRef++;
        return "Has jugado ya" + countRef + "veces";
    }
}
