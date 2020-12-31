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

    }

    ///<summary>
    /// Restarts an specific level
    ///</summary>
    public static void RestartLevel(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
        Time.timeScale = 1.0f;
    }
}
