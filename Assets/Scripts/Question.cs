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
    public static bool answerCorrect = false;
    public void RightAnswer()
    {
        greenFlag.SetActive(true);
        answerCorrect = true;
        nextQuestion.SetActive(true);
        gameObject.SetActive(false);
        if (!looped)
        {
            QuestionManager.Instance.NextQuestion();
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
