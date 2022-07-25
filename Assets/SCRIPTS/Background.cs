using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Transform Background1;
    public Transform Background2;
    void Update()
    {
        if(Background1.position.x <= -160f)
        {
            Background1.position = new Vector3(157f, -1.18f, 0);
        }
        if (Background2.position.x <= -160f)
        {
            Background2.position = new Vector3(157f, -1.18f, 0);
        }

        Vector3 speed = new Vector3(-20,0,0);
        Background1.position += speed * Time.deltaTime;
        Background2.position += speed * Time.deltaTime;
    }
}
