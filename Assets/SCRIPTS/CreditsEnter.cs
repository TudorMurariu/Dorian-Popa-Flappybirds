using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class CreditsEnter : MonoBehaviour
{
   public void EnterCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
