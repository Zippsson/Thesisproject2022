using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    //public QuestionManager questionManager;
    public SceneManagment sceneManager;
    [HideInInspector] public bool levelFinished = false;
    [HideInInspector] public bool returnToMenu =false;
    [HideInInspector] public bool levelSelect = false;
    [HideInInspector] public bool selectLevel = false;
    [HideInInspector] public int levelNr = 0;

    private int score;
    public int Score { get { return score; } set { score = value; } }

    void Awake()
    {
        if (Instance == null) // If there is no instance already
        {
            DontDestroyOnLoad(gameObject); // Keep the GameObject, this component is attached to, across different scenes
            Instance = this;
        }
        else if (Instance != this) // If there is already an instance and it's not `this` instance
        {
            Destroy(gameObject); // Destroy the GameObject, this component is attached to
        }
    }

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        if(levelFinished == true)
        {
            sceneManager.NextLevel();
            levelFinished = false;
        }

        if(returnToMenu == true)
        {
            sceneManager.GetMainMenu();
            returnToMenu = false;
        }

        if (levelSelect == true)
        {
            sceneManager.GetLevel(7);
            levelSelect = false;
        }

        if (selectLevel == true)
        {
            sceneManager.GetLevel(levelNr);
            levelNr = 0;
            selectLevel = false;
        }
    }
}
