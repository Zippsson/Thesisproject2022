using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    Scene scene;
    public static SceneManagment Instance { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(scene.buildIndex+1);
    }
}
