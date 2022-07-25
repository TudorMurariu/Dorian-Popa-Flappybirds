using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemeText : MonoBehaviour
{
    public Text t1;
    public Text t2;
    private string String1 = "Wait, Its all BUG MAFIA ?";
    private string String2 = "It always has been .";
    void Start()
    {
        //Wait,
        //Its all BUG MAFIA ?
        //It always has been .
        StartCoroutine(WaitBefore());    
    }
    IEnumerator WaitBefore()
    {
        yield return new WaitForSeconds(2);
        for (int i = 0; i < String1.Length; i++)
        {
            t1.text += String1[i];
            yield return new WaitForSeconds(0.1f);
            if(i == 5)
                yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < String2.Length; i++)
        {
            t2.text += String2[i];
            yield return new WaitForSeconds(0.1f);
        }
    }
   
}
