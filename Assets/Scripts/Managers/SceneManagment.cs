using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    Scene scene;
    public static SceneManagment Instance { get; private set; }
    [SerializeField] AudioSource click;
    int currentLevel = 0;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    public void NextLevel()
    {
        click.Play();
        currentLevel++;
        Debug.Log("Scene number: " + scene.buildIndex + 1);
        SceneManager.LoadScene(currentLevel);
    }

    public void Restart()
    {
        click.Play();
        SceneManager.LoadScene(scene.buildIndex);
    }

    public void GetMainMenu()
    {
        currentLevel = 0;
        click.Play();
        SceneManager.LoadScene(0);
    }

    public void GetLevel(int levelIndex)
    {
        click.Play();
        SceneManager.LoadScene(levelIndex);
    }
}
