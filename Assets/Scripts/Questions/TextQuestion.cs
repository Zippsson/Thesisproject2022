using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestion : Question
{
    [SerializeField] private TMPro.TMP_InputField textInput;
    [SerializeField] private string rightAnswer;

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
}
