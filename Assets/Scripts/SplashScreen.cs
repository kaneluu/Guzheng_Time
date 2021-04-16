using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public static string scene;

    void Start()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if(sceneName == "Splash")
        {
            StartCoroutine(Splash());
        }
    }

    IEnumerator Splash()
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Main");
    }
}
