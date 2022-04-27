using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    [SerializeField] GameObject audioOn;
    [SerializeField] GameObject audioOff;
    static bool toggle;

    private void Start()
    {
        if (toggle)
        {
            audioOn.SetActive(true);
            audioOff.SetActive(false);
        }
        else if (!toggle)
        {
            audioOn.SetActive(false);
            audioOff.SetActive(true);
        }
    }
    public void ToggleSound()
    {
        toggle = !toggle;

        if (toggle)
        {
            audioOn.SetActive(true);
            audioOff.SetActive(false);
            AudioListener.volume = 1f;
        }
        else
        {
            audioOn.SetActive(false);
            audioOff.SetActive(true);
            AudioListener.volume = 0f;
        }
    }
}
