using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    [SerializeField] GameObject greenFlag;
    [SerializeField] GameObject redFlag;
    [HideInInspector] public bool looped = false;
    [HideInInspector] public bool answerCorrect = false;
    [HideInInspector] public bool isActive = false;
    private void Awake()
    {
        gameObject.SetActive(true);
    }
    public void RightAnswer()
    {
        greenFlag.SetActive(true);
        answerCorrect = true;
        QuestionManager.Instance.NextQuestion(this);
    }

    public void WrongAnswer()
    {
        redFlag.SetActive(true);
        answerCorrect = false;
        QuestionManager.Instance.NextQuestion(this);
        looped = true;
    }
}
