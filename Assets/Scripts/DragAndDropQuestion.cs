using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropQuestion : Question
{
    [SerializeField] private GameObject answerPosition;
    [SerializeField] private GameObject rightAnswer;
    [SerializeField] private GameObject wrongAnswer;

    private void Update()
    {
        if(answerPosition.GetComponent<AnswerCollisionDetection>().answerCorrect == true)
        {
            RightAnswer();
        }
    }
}
