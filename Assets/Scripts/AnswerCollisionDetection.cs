using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerCollisionDetection : MonoBehaviour
{
    public bool answerCorrect = false;
    public bool answerWrong = false;
    public DragAndDropQuestion ddq;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!collision.gameObject.GetComponent<DragableUIComponent>())
        {
            return;
        }
        else if (collision.gameObject.GetComponent<DragableUIComponent>().startDragging == false)
        {
            Debug.Log("Collision has been detected!");
            if (collision.gameObject.tag == "RightAnswer")
            {
                Debug.Log("Right answer");
                gameObject.GetComponent<Collider2D>().enabled = false;
                ddq.RightAnswer();
                //answerWrong = false;
                //answerCorrect = true;
            }
            else if (collision.gameObject.tag == "WrongAnswer")
            {
                Debug.Log("Wrong answer");
                //gameObject.GetComponent<Collider2D>().enabled = false;
                collision.gameObject.GetComponent<DragableUIComponent>().ResetPos();
                ddq.WrongAnswer();
                //gameObject.GetComponent<Collider2D>().enabled = true;
                //answerWrong = true;
            }
        }
    }
}
