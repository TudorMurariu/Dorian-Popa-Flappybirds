using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text txt;

    void OnTriggerEnter2D()
    {
        int a = Convert.ToInt32(txt.text);
        txt.text = (a + 1).ToString();
    }
}
