using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    public static QuestionManager Instance { get; private set; }

    [SerializeField] List<Question> questionList = new List<Question>();

    public void NextQuestion()
    {
        ///if next question is last in list and if not all questions has been correctly answered, 
        ///then loop through incorrect questions until all are answered correctly.
    }

    public void LoopQuestions()
    {

    }


}
