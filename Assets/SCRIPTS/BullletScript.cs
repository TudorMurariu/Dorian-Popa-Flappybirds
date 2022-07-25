using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullletScript : MonoBehaviour
{
    public Rigidbody2D rbbbbbb;
    void Start()
    {
        rbbbbbb.AddForce(Vector2.right * 90000);
    }
}
