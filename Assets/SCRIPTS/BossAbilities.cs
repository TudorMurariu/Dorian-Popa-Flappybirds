using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class BossAbilities : MonoBehaviour
{
    public Transform trBoss;    
    public Text HP;
    public Text UCanShot;
    public AudioSource AD;
    public AudioClip AC;
    public Transform Dorian;
    public GameObject Bullet;
    public int nr = 0;
    void OnCollisionEnter2D()
    {
        ///-10
        HP.text = (Convert.ToInt32(HP.text) - 4).ToString();
    }

    void Start()
    {
        Invoke("AfiseazaText", 7);

        Invoke("AscundeText", 10);

        Invoke("LikeAMelody",7);
    }
    void Update()
    {
        ///INtrare boss
        ///
        Vector3 speed = new Vector3(-20, 0, 0);
        if(trBoss.position.x >= 53)
        {
            trBoss.position += speed * Time.deltaTime;
        }

        ///Moarte Boss
        if(Convert.ToInt32(HP.text) == 0)
        {
            Debug.Log("Win");
            SceneManager.LoadScene("Meme");
        }

        ///Dorian trage
        if(Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("shot");
            GameObject bullet = (GameObject)Instantiate(Bullet);
            bullet.transform.position = new Vector3(Dorian.position.x + 25, Dorian.position.y, Dorian.position.z);
            
        }          
    }
    void FixedUpdate()
    {
        //nr++;
        //if(nr % 150 == 0)
       // {
        //    GameObject bullet = (GameObject)Instantiate(Bullet);
       // }
    }
    private void AscundeText()
    {
        UCanShot.enabled = false;
        Debug.Log("AscundeText");
    }
    private void AfiseazaText()
    {
        UCanShot.text = "Press X to fire stuff LOOL";
    }

    private void LikeAMelody()
    {
        AD.PlayOneShot(AC);
    }
}
