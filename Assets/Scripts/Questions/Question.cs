using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    [SerializeField] GameObject greenFlag;
    [SerializeField] GameObject redFlag;
    public enum QuestionState { UNANSWERED, CORRECT, WRONG}
    public QuestionState questionState = QuestionState.UNANSWERED;
    [HideInInspector] public bool looped = false;
    //[HideInInspector] public bool answerCorrect = false;
    [HideInInspector] public bool isActive = false;
    [HideInInspector] public string answerData;

    private void Awake()
    {
        gameObject.SetActive(true);
    }

    public void RightAnswer()
    {
        greenFlag.SetActive(true);
        //answerCorrect = true;
        questionState = QuestionState.CORRECT;
        if(looped == true)
        {
            answerData = "X " + PlayerPrefs.GetString("id");
            redFlag.SetActive(false);
            greenFlag.SetActive(true);
            GameManager.Instance.Score += 50;
        }
        else
        {
            answerData = "O " + PlayerPrefs.GetString("id");
            GameManager.Instance.Score += 100;
        }
        QuestionManager.Instance.NextQuestion(this);
    }

    public void WrongAnswer()
    {
        redFlag.SetActive(true);
        //answerCorrect = false;
        questionState = QuestionState.WRONG;
        QuestionManager.Instance.NextQuestion(this);
        looped = true;
    }
}
