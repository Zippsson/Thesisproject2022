using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestion : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField textInput;
    [SerializeField] private string rightAnswer;
    [SerializeField] GameObject greenFlag;
    [SerializeField] GameObject redFlag;
    [SerializeField] GameObject nextQuestion;
    bool answerCorrect = false;
    bool looped = false;

    public void CorrectAnswer()
    {
        if(textInput.text == rightAnswer)
        {
            RightAnswer();
        }
        else
        {
            WrongAnswer();
        }
    }

    public void RightAnswer()
    {
        greenFlag.SetActive(true);
        answerCorrect = true;
        nextQuestion.SetActive(true);
        gameObject.SetActive(false);
        //if (!looped)
        //{
        //    QuestionManager.Instance.NextQuestion();
        //}
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
