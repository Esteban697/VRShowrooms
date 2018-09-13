using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{

    public string sceneName;

    public void ChangeScene()
    {

        // Prints to the console when the method is called
        Debug.Log("'ChangeScene()' was called");

        // Use SceneManager.LoadScene() and the Scene.name property to reload the scene
        SceneManager.LoadScene(sceneName);
    }
}
