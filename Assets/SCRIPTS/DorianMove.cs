using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DorianMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float JumpForce = 10f;
    public AudioSource AD;
    public AudioClip a1, a2, a3;
    public int JumpCount = 0;
    public Transform inaltime;
    public Text SCORE;
    public Transform TpDorian;

    void Update()
    {

        if (inaltime.position.y >= 50 || inaltime.position.y <= -50)
        {
            SCORE.color = Color.red;
            SCORE.text = "You Died";
            TpDorian.position = new Vector3(0,0,-1);
            Invoke("Death", 3);         
        }
        
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    void OnCollisionEnter2D()
    {
        SCORE.text = "You Died";
        SCORE.color = Color.red;
        TpDorian.position = new Vector3(0, 0, -1);
        Debug.Log("Deadd");
        Invoke("Death", 3);      
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * JumpForce;
        JumpCount++;
        if (JumpCount % 4 == 0) 
        {
            int rand = Random.Range(0, 3);
            if (rand == 0)
            {
                AD.PlayOneShot(a1);
            }
            else if (rand == 1)
            {
                AD.PlayOneShot(a2);
            }
            else if (rand == 2)
            {
                AD.PlayOneShot(a3);
            }
        }
    }

    private void Death()
    {
        SceneManager.LoadScene("FirstScene");
    }
}
