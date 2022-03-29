using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class Startup
{
    static Startup()
    {
        Debug.Log("Up and running");
        //var scene = UnityEngine.SceneManagement.SceneManager.CreateScene("ASD");
    }
}