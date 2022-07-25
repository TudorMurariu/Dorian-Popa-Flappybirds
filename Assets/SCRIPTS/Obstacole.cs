using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacole : MonoBehaviour
{
    public bool yes = true;
    public Transform[] Columns = new Transform[5]; 
    void Update()
    {
        if(yes)
        {
            float rand = Random.Range(-22, 22);

            for (int i = 0; i < 5; i++)
            {
                if (Columns[i].position.x <= -86)
                    Columns[i].position = new Vector3(99, rand, 0);
            }
        }

        Vector3 speed = new Vector3(-20, 0, 0);

        for (int i = 0; i < 5; i++)
        {
            Columns[i].position += speed * Time.deltaTime;
        }
    }
}
