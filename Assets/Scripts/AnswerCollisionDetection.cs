using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerCollisionDetection : MonoBehaviour
{
    public bool answerCorrect = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "RightAnswer")
        {
            answerCorrect = true;
        }
        else if(collision.gameObject.tag == "WrongAnswer")
        {
            Debug.Log("Wrong answer");
        }
    }
}
