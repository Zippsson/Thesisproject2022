using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDUsers : MonoBehaviour
{
    [SerializeField] TMPro.TMP_InputField id;
    [SerializeField] GameObject menuGO;
    bool hasRecievedInput =false;
    private void Start()
    {
        if (hasRecievedInput)
        {
            gameObject.SetActive(false);
        }
    }
    public void PostID()
    {
        if (id.text.Length == 6)
        {
            PlayerPrefs.SetString("id", id.text);
            hasRecievedInput = true;
            gameObject.SetActive(false);
            menuGO.SetActive(true);
        }
        else
            return;
    }

}
