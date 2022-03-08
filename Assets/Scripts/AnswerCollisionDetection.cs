using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerCollisionDetection : MonoBehaviour
{
    public bool answerCorrect = false;
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("Collision has been detected!");
    //    if(collision.gameObject.tag == "RightAnswer")
    //    {
    //        Debug.Log("Right answer");
    //        answerCorrect = true;
    //    }
    //    else if(collision.gameObject.tag == "WrongAnswer")
    //    {
    //        Debug.Log("Wrong answer");
    //    }
    //}

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Collision has been detected!");
        if (collision.gameObject.tag == "RightAnswer")
        {
            Debug.Log("Right answer");
            answerCorrect = true;
        }
        else if (collision.gameObject.tag == "WrongAnswer")
        {
            Debug.Log("Wrong answer");
        }
    }
}