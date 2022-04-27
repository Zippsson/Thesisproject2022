using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    public static QuestionManager Instance { get; private set; }
    [SerializeField] WinScreen winScript;
    [SerializeField] GameObject winScreen;
    [SerializeField] protected List<Question> questionList = new List<Question>();
    public List<bool> boolList = new List<bool>();
    [SerializeField] AudioSource click;
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
        ResetScore();
    }

    private void Update()
    {
        boolList = new List<bool>();
        foreach (Question item in questionList)
        {
            boolList.Add(item.looped);
        }
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
        click.Play();
        q.gameObject.SetActive(false);
        bool winCheck = true;
        foreach  (Question quest in questionList)
        {
            if(quest.questionState == Question.QuestionState.UNANSWERED || quest.questionState == Question.QuestionState.WRONG)
            {
                winCheck = false;
            }
        }
        if (winCheck == false)
        {
            if(questionList.IndexOf(q) > -1 && questionList.IndexOf(q) < questionList.Count-1)
            {
                if(questionList[questionList.IndexOf(q) + 1].questionState == Question.QuestionState.CORRECT)
                {
                    NextQuestion(questionList[questionList.IndexOf(q) + 1]);
                }
                else
                {
                    questionList[questionList.IndexOf(q) + 1].gameObject.SetActive(true);
                }
            }
            else if(questionList.IndexOf(q) == questionList.Count -1)
            {
                foreach(Question qu in questionList)
                {
                    if(qu.questionState == Question.QuestionState.WRONG)
                    {
                    Debug.Log("First wrong: " + qu.gameObject.name);
                        qu.gameObject.SetActive(true);
                        break;
                    }                   
                }
            }
        }
        else
        {
            WinScreenActivate();
        }
    }

    public void LoopQuestions()
    {
        ///If questions are not all answered correctly then loop through the questions until all are correct.
        if(looped == false)
        {
            looped = true;
        }
    }
    public void WinScreenActivate()
    {
        winScreen.gameObject.SetActive(true);
        winScript.UpdateScore();
        winScript.AssignStarsToScore();
    }

    public void ResetScore()
    {
        GameManager.Instance.Score = 0;
    }
}
