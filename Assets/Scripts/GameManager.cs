using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    private int score;
    public int Score { get { return score; } set { score = value; } }

    private void Start()
    {
        score = 0;
    }
}
