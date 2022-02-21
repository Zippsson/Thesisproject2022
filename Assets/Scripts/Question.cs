using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    [SerializeField] GameObject greenFlag;
    [SerializeField] GameObject redFlag;
    [SerializeField] GameObject nextQuestion;
    bool looped = false;
    bool answerCorrect = false;
    public void RightAnswer()
    {
        greenFlag.SetActive(true);
        answerCorrect = true;
        gameObject.SetActive(false);
        nextQuestion.SetActive(true);
        if (!looped)
        {
            // GameManager.Instance.Score += 100;
        }
    }

    public void WrongAnswer()
    {
        redFlag.SetActive(true);
        answerCorrect = false;
        // GameManager.Instance.Score += 100;
        gameObject.SetActive(false);
        nextQuestion.SetActive(true);
        looped = true;
    }

    
}
