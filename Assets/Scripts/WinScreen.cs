using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class WinScreen : MonoBehaviour
{
    [SerializeField] GameObject star1;
    [SerializeField] GameObject star2;
    [SerializeField] GameObject star3;
    [SerializeField] AudioSource victorySound;

    [SerializeField] TMPro.TMP_Text score;
    /// <summary>
    /// Referes to the name of the level that in turn correlates with the number of stars unlocked in each level.
    /// </summary>
    [SerializeField] string levelName;

    public void UpdateScore()
    {
        score.SetText(GameManager.Instance.Score.ToString());
    }

    private void OnEnable()
    {
        victorySound.Play();
    }

    public void AssignStarsToScore()
    {
        if(GameManager.Instance.Score <= 350)
        {
            star1.SetActive(true);
            PlayerPrefs.SetInt(levelName, 1);
        }
        else if(GameManager.Instance.Score <= 450)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            PlayerPrefs.SetInt(levelName, 2);
        }
        else if(GameManager.Instance.Score == 500)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            PlayerPrefs.SetInt(levelName, 3);
        }
        else
        {
            return;
        }
    }

    public void LevelFinished()
    {
        GameManager.Instance.levelFinished = true;
    }

    public void ReturnToMenu()
    {
        GameManager.Instance.returnToMenu = true;
    }

    public void LevelSelect()
    {
        GameManager.Instance.levelSelect = true;
    }

    public void SelectLevel(int levelNr)
    {
        GameManager.Instance.selectLevel = true;
        GameManager.Instance.levelNr = levelNr;
    }
}
