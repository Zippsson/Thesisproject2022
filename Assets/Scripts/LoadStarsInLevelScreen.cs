using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStarsInLevelScreen : MonoBehaviour
{
    [SerializeField] GameObject star1;
    [SerializeField] GameObject star2;
    [SerializeField] GameObject star3;

    [SerializeField] private string levelName;
    private void Start()
    {
        if(PlayerPrefs.GetInt(levelName) == 1)
        {
            star1.SetActive(true);
        }
        else if(PlayerPrefs.GetInt(levelName) == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(levelName) == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
    }
}
