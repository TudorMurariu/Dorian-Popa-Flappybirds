using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Boss : MonoBehaviour
{
    public Text score;
    public Obstacole obs;
    public BossAbilities BosA;

    void Update()
    {//11.1 11.1
        if (Convert.ToInt32(score.text) > 11)
        {
            obs.yes = false;
            BosA.enabled = true;
        } 
    }
}
