using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropQuestion : Question
{
    [SerializeField] private AnswerCollisionDetection answerPosition;
    [SerializeField] private GameObject rightAnswer;
    [SerializeField] private GameObject wrongAnswer1;
    [SerializeField] private GameObject wrongAnswer2;
    Collider2D col;

    private Vector2 wrongAnswerPos;

    //private void Awake()
    //{
    //    wrongAnswerPos = new Vector2(wrongAnswer.transform.position.x, wrongAnswer.transform.position.y);
    //    col = wrongAnswer.GetComponent<Collider2D>();
    //    Debug.Log("position= " + wrongAnswer.transform.position);
    //}
    //private void Update()
    //{
    //    if(answerPosition.answerCorrect == true)
    //    {
    //        RightAnswer();
    //    }
    //    else if(answerPosition.answerWrong == true)
    //    {
    //        WrongAnswer();
    //    }
    //}
}
