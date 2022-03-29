using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SendToGoogleForm : MonoBehaviour
{
    public Question question1;
    public Question question2;
    public Question question3;
    public Question question4;
    public Question question5;
    public TMPro.TMP_Text score;

    [SerializeField] private string fieldName1;
    [SerializeField] private string fieldName2;
    [SerializeField] private string fieldName3;      
    [SerializeField] private string fieldName4;
    [SerializeField] private string fieldName5;
    [SerializeField] private string fieldName6;

    private string answer1;
    private string answer2;
    private string answer3;
    private string answer4;
    private string answer5;
    private string Score;

    private string URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLSdtDVHlajLa8IwB4zbNQ07wLHK7HxP1VCGsuFwgAzi_ADMBjw/formResponse";

    IEnumerator Post(string ans1, string ans2, string ans3, string ans4, string ans5, string score)
    {
        WWWForm Form = new WWWForm();
        Form.AddField(fieldName1, ans1);
        Form.AddField(fieldName2, ans2);
        Form.AddField(fieldName3, ans3);
        Form.AddField(fieldName4, ans4);
        Form.AddField(fieldName5, ans5);
        Form.AddField(fieldName6, score);

        using (UnityWebRequest www = UnityWebRequest.Post(URL, Form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }
        }
    }

    public void Send()
    {
        answer1 = question1.answerData;
        answer2 = question2.answerData;
        answer3 = question3.answerData;
        answer4 = question4.answerData;
        answer5 = question5.answerData;
        Score = score.text;

        StartCoroutine(Post(answer1, answer2, answer3, answer4, answer5, Score));
    }
}
