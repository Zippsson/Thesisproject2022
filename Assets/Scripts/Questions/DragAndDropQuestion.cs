using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropQuestion : Question
{
    [SerializeField] private AnswerCollisionDetection answerPosition;
    [SerializeField] private GameObject rightAnswer;
    [SerializeField] private GameObject wrongAnswer;

    private void Update()
    {
        if(answerPosition.answerCorrect == true)
        {
            RightAnswer();
        }
        else if(answerPosition.answerWrong == true)
        {
            WrongAnswer();
        }
    }
}
