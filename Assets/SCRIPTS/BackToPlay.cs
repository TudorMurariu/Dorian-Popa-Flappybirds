using UnityEngine.SceneManagement;
using UnityEngine;

public class BackToPlay : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("FirstScene");
    }
}
