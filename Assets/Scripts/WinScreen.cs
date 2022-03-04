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

    public void UpdateScore()
    {
        score.SetText(GameManager.Instance.Score.ToString());
    }

    public void AssignStarsToScore()
    {
        if(GameManager.Instance.Score <= 350)
        {
            star1.SetActive(true);
        }
        else if(GameManager.Instance.Score <= 450)
        {
            star2.SetActive(true);
        }
        else
        {
            star3.SetActive(true);
        }
    }
}
