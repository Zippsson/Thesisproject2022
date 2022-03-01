using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    public static QuestionManager Instance { get; private set; }
    [SerializeField] GameObject winScreen;
    [SerializeField] protected List<Question> questionList = new List<Question>();
    bool looped = false;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        PopulateList();
        questionList[0].gameObject.SetActive(true);
    }

    /// <summary>
    /// Populates the List with Questions that it finds in the Scene, and then sets them to inactive.
    /// </summary>
    public void PopulateList()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject g = GameObject.Find("Question" + i);
            questionList.Add(g.GetComponent<Question>());
            g.SetActive(false);
        }   
    }
    public void NextQuestion(Question q)
    {
        Debug.Log("looped: " + looped);
        if (looped == false)
        {
            if(questionList.IndexOf(q) > -1 && questionList.IndexOf(q) < questionList.Count-1)
            {
                q.gameObject.SetActive(false);
                questionList[questionList.IndexOf(q) + 1].gameObject.SetActive(true);
            }
            else if(questionList.IndexOf(q) == questionList.Count-1)
            {
                q.gameObject.SetActive(false);
                foreach(Question qu in questionList)
                {
                    if(qu.answerCorrect == false)
                    {
                        LoopQuestions();
                        break;
                    }
                    else
                    {
                        q.gameObject.SetActive(false);
                        WinScreenActivate();
                    }
                }
            }
        }
        else
        {
            LoopQuestions();
        }
        ///if next question is last in list and if not all questions has been correctly answered, 
        ///then loop through incorrect questions until all are answered correctly.
    }

    public void LoopQuestions()
    {
        ///If questions are not all answered correctly then loop through the questions until all are correct.
        if(looped == false)
        {
            looped = true;
        }

        foreach (Question q in questionList)
        {
            if(q.answerCorrect == false)
            {
                q.gameObject.SetActive(true);
                break;
            }
            else if(questionList.IndexOf(q) == questionList.Count - 1)
            {
                WinScreenActivate();
            }
        }
    }
    public void WinScreenActivate()
    {

        winScreen.gameObject.SetActive(true);
    }

}
