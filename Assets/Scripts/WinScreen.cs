using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    [SerializeField] GameObject star1;
    [SerializeField] GameObject star2;
    [SerializeField] GameObject star3;

    [SerializeField] TMPro.TMP_Text score;
    /// <summary>
    /// Referes to the name of the level that in turn correlates with the number of stars unlocked in each level.
    /// </summary>
    [SerializeField] string levelName;
    public void UpdateScore()
    {
        score.SetText(GameManager.Instance.Score.ToString());
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
}
