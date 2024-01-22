using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class UI_Controller : MonoBehaviour
{
    public GameObject UI_Introduction;
    
    
    // Start is called before the first frame update
    public void BTN_Next()
    {
        UI_Introduction.SetActive(false);
    }

    private void Update()
    {
        switch (GameManager.beginGame)
        {
            case "Introduction":
                ActiveIntroduction();
            break;
        }
            
    }

    private void ActiveIntroduction()
    {
        UI_Introduction.SetActive(true);
        GameManager.beginGame = "";
    }
}
