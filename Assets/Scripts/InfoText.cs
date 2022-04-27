using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoText : MonoBehaviour
{
    static bool hasBeenSeen = false;
    public GameObject mainMenu;
    private void Start()
    {
        if (hasBeenSeen)
        {
            gameObject.SetActive(false);
        }    
    }
    public void DisableInfoWindow()
    {
        hasBeenSeen = true;
        gameObject.SetActive(false);
        mainMenu.SetActive(true);
    }
}
