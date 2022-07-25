using UnityEngine.SceneManagement;
using UnityEngine;

public class Play : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("Game");
    }
}
