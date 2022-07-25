using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("it works");
    }
}
